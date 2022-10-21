using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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

			try
			{
				// Get the PickTrace records for the date provided
				var truncatedDate = new DateTime(date.Year, date.Month, date.Day);
				var response = _searchRepo.Get(truncatedDate, truncatedDate.AddDays(1), new List<string>(), true, true);

				// Add all of the records into the staging table.
				_context.PickTrace_Fact_Payroll_Staging.AddRange(response.WageData);
				_context.SaveChanges();

				// Invoke the stored procedure to merge the records into the production table.
				_context.Database.ExecuteSqlRaw("EXEC dbo.PickTrace_Fact_Payroll_MergeFromStaging");

			}
			catch(Exception ex)
			{
				_logger.LogError("An error occured during SynchronizeDate(). Message: {message}", ex.Message);
			}
		}
	}
}
