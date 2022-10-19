using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PickTraceSync.Data.PickTraceApi;

namespace PickTraceSync.Tests
{
	[TestClass]
	public class PickTraceAuthenticatorTests
	{
		private IConfigurationRoot _configuration;
		private IHttpHandler _httpHandler = new PickTraceSync.Data.PickTraceApi.HttpClientHandler();
		private MockLogger<PickTraceAuthenticator> _logger = new MockLogger<PickTraceAuthenticator>();

		[TestMethod]
		public void Test()
		{
			_configuration ??= ConfigurationHelper.GetIConfigurationRoot();
			var username = _configuration["PickTrace:Username"];
			var password = _configuration["PickTrace:Password"];
			var orgId = _configuration["PickTrace:OrgId"];

			var authenticator = new PickTraceAuthenticator(_logger, _httpHandler, username, password, orgId);
			Assert.IsNotNull(authenticator);
			Assert.AreNotEqual("", authenticator.Token());
		}
	}
}