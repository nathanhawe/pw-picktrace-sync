using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PickTraceSync.Data.PickTraceApi
{
	public class PickTraceAuthenticator : IPickTraceAuthenticator
	{
		private readonly ILogger<PickTraceAuthenticator> _logger;
		private readonly IHttpHandler _httpHandler;
		private readonly string _username;
		private readonly string _password;
		private readonly string _organizationId;
		private string? _token;
		private string? _refreshToken;

		protected class AuthenticationResponse
		{
			public string? Token { get; set; }
			public string? RefreshToken { get; set; }
		}

		public PickTraceAuthenticator(ILogger<PickTraceAuthenticator> logger, IHttpHandler httpHandler, string username, string password, string organizationId)
		{
			_logger = logger ?? throw new ArgumentNullException(nameof(logger));
			_httpHandler = httpHandler ?? throw new ArgumentNullException(nameof(httpHandler));
			_username = username ?? throw new ArgumentNullException(nameof(username));
			_password = password ?? throw new ArgumentNullException(nameof(password));
			_organizationId = organizationId ?? throw new ArgumentNullException(nameof(organizationId));

			// Attempt login
			try
			{
				Login();
			}
			catch(HttpRequestException ex)
			{
				_logger.LogError("An exception was thrown while attempting to login to PickTrace. Message: <Message>", ex.Message);
			}
		}
		public string Token()
		{
			return _token ?? "";
		}

		public string OrganizationId()
		{
			return _organizationId ?? "";
		}

		private async void Login()
		{
			var url = @"https://app.picktrace.com/api/accounts/tokens";
			using StringContent jsonContent = new(
				JsonSerializer.Serialize(new
				{
					email = _username,
					password = _password,
				}),
				Encoding.UTF8,
				"application/json");

			using HttpResponseMessage response = _httpHandler.Post(url, jsonContent);
			
			response.EnsureSuccessStatusCode();

			AuthenticationResponse? result = await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
			_token = result?.Token;
			_refreshToken = result?.RefreshToken;

		}
	}
}
