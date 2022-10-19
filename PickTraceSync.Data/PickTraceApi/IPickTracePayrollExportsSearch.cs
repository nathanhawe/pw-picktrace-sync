namespace PickTraceSync.Data.PickTraceApi
{
	public interface IPickTracePayrollExportsSearch
	{
		public PickTraceSync.Domain.PayrollExportsSearchResponse Get(DateTime start, DateTime end, List<string> employerNames, bool useUpdatedAt, bool includeArchived);
	}
}
