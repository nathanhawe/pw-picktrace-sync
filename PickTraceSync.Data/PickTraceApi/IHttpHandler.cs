namespace PickTraceSync.Data.PickTraceApi
{
	public interface IHttpHandler
	{
		HttpResponseMessage Get(string url);
		HttpResponseMessage Post(string url, HttpContent content);
		HttpResponseMessage Send(HttpRequestMessage httpRequestMessage);
		Task<HttpResponseMessage> GetAsync(string url);
		Task<HttpResponseMessage> PostAsync(string url, HttpContent content);
		Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage);
	}
}
