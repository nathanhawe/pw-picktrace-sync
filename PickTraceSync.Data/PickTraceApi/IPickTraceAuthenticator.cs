namespace PickTraceSync.Data.PickTraceApi
{
	public interface IPickTraceAuthenticator
	{
		public string Token();
		public string OrganizationId();
	}
}
