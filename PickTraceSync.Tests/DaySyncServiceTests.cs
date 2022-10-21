using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PickTraceSync.Data;
using PickTraceSync.Data.PickTraceApi;
using PickTraceSync.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpClientHandler = PickTraceSync.Data.PickTraceApi.HttpClientHandler;

namespace PickTraceSync.Tests
{
	[TestClass]
	public class DaySyncServiceTests
	{
		private IConfiguration _configuration;
		private readonly IHttpHandler _httpHandler = new PickTraceSync.Data.PickTraceApi.HttpClientHandler();
		private PrimaDwContext _context;
		private DateSyncService _service;


		[TestInitialize]
		public void Setup()
		{
			_configuration ??= ConfigurationHelper.GetIConfigurationRoot();
			var username = _configuration["PickTrace:Username"];
			var password = _configuration["PickTrace:Password"];
			var orgId = _configuration["PickTrace:OrgId"];

			var options = new DbContextOptionsBuilder<PrimaDwContext>()
				.UseSqlServer(_configuration.GetConnectionString("DWConnection"))
				.Options;

			_context = new PrimaDwContext(options);

			var authenticator = new PickTraceAuthenticator(new MockLogger<PickTraceAuthenticator>(), _httpHandler, username, password, orgId);
			var searchRepo = new PickTracePayrollExportsSearch(new MockLogger<PickTracePayrollExportsSearch>(), _httpHandler, authenticator);
			_service = new DateSyncService(new MockLogger<DateSyncService>(), _context, searchRepo);
		}

		[TestMethod]
		public void SynchronizeDate()
		{
			_service.SynchronizeDate(DateTime.Now);
		}
	}
}
