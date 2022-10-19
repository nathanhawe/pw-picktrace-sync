namespace PickTraceSync.Domain
{
	public class PayrollExportsSearchResponse
	{
		public List<PayrollExportRecord> WageData { get; set; } = new List<PayrollExportRecord>();
	}
}