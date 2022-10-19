using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PickTraceSync.Data.PickTraceApi;
using PickTraceSync.Domain;

namespace PickTraceSync.Tests
{
	[TestClass]
	public class PickTracePayrollExportsSearchTests
	{
		private IConfigurationRoot _configuration;
		private IHttpHandler _httpHandler = new PickTraceSync.Data.PickTraceApi.HttpClientHandler();
		private MockLogger<PickTracePayrollExportsSearch> _logger = new MockLogger<PickTracePayrollExportsSearch>();
		private PickTraceAuthenticator _authenticator;

		[TestInitialize]
		public void Setup()
		{
			_configuration ??= ConfigurationHelper.GetIConfigurationRoot();
			var username = _configuration["PickTrace:Username"];
			var password = _configuration["PickTrace:Password"];
			var orgId = _configuration["PickTrace:OrgId"];
			_authenticator = new PickTraceAuthenticator(new MockLogger<PickTraceAuthenticator>(), _httpHandler, username, password, orgId);
		}
		[TestMethod]
		public void Test()
		{
			var search = new PickTracePayrollExportsSearch(_logger, _httpHandler, _authenticator);
			var results = search.Get(new DateTime(2022, 10, 18), new DateTime(2022, 10, 19), null, true, true);

			Print(results.WageData);

		}

		private void Print(IEnumerable<PayrollExportRecord> lines)
		{
			Console.WriteLine($"There are '{lines.Count()}' PayrollExportRecords:");
			foreach (var line in lines)
			{
				Print(line);
				Console.WriteLine("");
			}
		}

		private void Print(PayrollExportRecord line)
		{
			var properties = typeof(PayrollExportRecord).GetProperties();
			foreach (var property in properties)
			{
				Console.Write($"     {property.Name}: '{property.GetValue(line)}'");
			}
		}
	}
}