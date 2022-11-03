namespace PickTraceSync.Data.PickTraceApi
{
	public class HttpClientHandler : IHttpHandler
	{
		private readonly HttpClient _client = new();
		public HttpClientHandler()
		{
			_client.Timeout = TimeSpan.FromMinutes(10);
		}

		public HttpResponseMessage Get(string url)
		{
			return GetAsync(url).Result;
		}

		public async Task<HttpResponseMessage> GetAsync(string url)
		{
			return await _client.GetAsync(url);
		}

		public HttpResponseMessage Post(string url, HttpContent content)
		{
			return PostAsync(url, content).Result;
		}

		public async Task<HttpResponseMessage> PostAsync(string url, HttpContent content)
		{
			return await _client.PostAsync(url, content);
		}

		public HttpResponseMessage Send(HttpRequestMessage httpRequestMessage)
		{
			return SendAsync(httpRequestMessage).Result;
		}

		public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage)
		{
			return await _client.SendAsync(httpRequestMessage);
		}
	}
}
