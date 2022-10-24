using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PickTraceSync.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickTraceSync.Service
{
	public class DateSyncService : IDateSynchronizationService
	{
		private readonly ILogger _logger;
		private readonly Data.PrimaDwContext _context;
		private readonly Data.PickTraceApi.IPickTracePayrollExportsSearch _searchRepo;
		public DateSyncService(
			ILogger<DateSyncService> logger, 
			Data.PrimaDwContext context, 
			Data.PickTraceApi.IPickTracePayrollExportsSearch searchRepo)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_context = context ?? throw new ArgumentNullException(nameof(context));
			_searchRepo = searchRepo ?? throw new ArgumentNullException(nameof(searchRepo));
		}

		public void SynchronizeDate(DateTime date)
		{
			_logger.LogDebug("Attempting to synchronize the date: {date}.", date);
			PayrollExportsSearchResponse response;
			try
			{
				// Get the PickTrace records for the date provided
				var truncatedDate = new DateTime(date.Year, date.Month, date.Day);

				while((response = _searchRepo.Get(truncatedDate, truncatedDate.AddDays(1), new List<string>(), true, true)).IsRateLimited)
				{
					_logger.LogInformation("Retrying in '{seconds}'", response.RetryAfterSeconds);
					Thread.Sleep(response.RetryAfterSeconds * 1000);
				}

				// Add all of the records into the staging table.
				_context.PickTrace_Fact_Payroll_Staging.AddRange(response.WageData);
				_context.SaveChanges();

				// Invoke the stored procedure to merge the records into the production table.
				_context.Database.ExecuteSqlRaw("EXEC dbo.PickTrace_Fact_Payroll_MergeFromStaging");

				_logger.LogInformation("Finished processing {count} records.", response.WageData.Count);

			}
			catch(Exception ex)
			{
				_logger.LogError("An error occured during SynchronizeDate(). Message: {message}", ex.Message);
			}
		}

		public void SynchronizeDateRange(DateTime startDate, DateTime endDate)
		{
			var start = new DateTime(startDate.Year, startDate.Month, startDate.Day);
			var end = new DateTime(endDate.Year, endDate.Month, endDate.Day);
			var span = end - start;
			
			for(int i = 0; i <= span.Days; i++ )
			{
				SynchronizeDate(start.AddDays(i));

				// Reset internal state of EF context
				_context.ChangeTracker.Clear();
			}
		}
	}
}
