using Microsoft.Extensions.Logging;
using PickTraceSync.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PickTraceSync.Data.PickTraceApi
{
	public class PickTracePayrollExportsSearch : IPickTracePayrollExportsSearch
	{
		private readonly ILogger<PickTracePayrollExportsSearch> _logger;
		private readonly IHttpHandler _httpHandler;
		private readonly IPickTraceAuthenticator _authenticator;

		public PickTracePayrollExportsSearch(
			ILogger<PickTracePayrollExportsSearch> logger, 
			IHttpHandler httpHandler, 
			IPickTraceAuthenticator authenticator)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_httpHandler = httpHandler ?? throw new ArgumentNullException(nameof(httpHandler));
			_authenticator = authenticator ?? throw new ArgumentNullException(nameof(authenticator));
		}

		public PayrollExportsSearchResponse Get(
			DateTime start, 
			DateTime end, 
			List<string> employerNames, 
			bool useUpdatedAt = false, 
			bool includeArchived = false)
		{
			try
			{
				_logger.LogDebug("PickTracePayrollExportsSearch.Get() invoked. start:'{start}', end:'{end}', employerNames:'{employerNames}', useUpdatedAt: '{useUpdatedAt}', includeArchived: '{includeArchived}'.", start, end, employerNames, useUpdatedAt, includeArchived);
				return GetAsync(start, end, employerNames, useUpdatedAt, includeArchived).Result;	
			}
			catch(Exception ex)
			{
				_logger.LogError("An exception was thrown while attempting to retrieve Payroll Exports.  Message: {Message}", ex.Message);
			}

			return new PayrollExportsSearchResponse();
		}

		private async Task<PayrollExportsSearchResponse> GetAsync(DateTime start, DateTime end, List<string> employerNames, bool useUpdatedAt, bool includeArchived)
		{
			var token = _authenticator.Token();
			var orgId = _authenticator.OrganizationId();
			var url = @"https://app.picktrace.com/api/payroll-exports/search";
			var request = new HttpRequestMessage(HttpMethod.Post, url);
		
			using StringContent jsonContent = new(
				JsonSerializer.Serialize(new
				{
					startDateTime = start.ToString("yyyy-MM-ddTHH:mm:ss.000Z"),
					endDateTime = end.ToString("yyyy-MM-ddTHH:mm:ss.000Z"),
					employerNames = employerNames ?? new List<string>(),
					useUpdatedAt = useUpdatedAt,
					includeArchivedTimecards = includeArchived
				}),
				Encoding.UTF8,
				"application/json");
			request.Content = jsonContent;
			request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
			request.Headers.Add("PT-Organization-ID", orgId);

			using HttpResponseMessage response = _httpHandler.Send(request);

			response.EnsureSuccessStatusCode();

			var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
			options.Converters.Add(new CustomDecimalConverter());
			var result = await response.Content.ReadFromJsonAsync<PayrollExportsSearchResponse>(options);
			return result ?? new PayrollExportsSearchResponse();
		}
	}
}
