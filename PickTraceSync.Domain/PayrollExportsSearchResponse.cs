using System.Text.Json.Serialization;

namespace PickTraceSync.Domain
{
	/// <summary>
	/// This class represents the response object returned from PickTrace's payroll export API end point enriched
	/// with rate limit handling information.
	/// </summary>
	public class PayrollExportsSearchResponse
	{
		/// <summary>
		/// If true, indicates that a 429 response was returned and the <c>RetryAfterSeconds</c> property 
		/// will indidate the number of seconds to wait before retrying.
		/// </summary>
		[JsonIgnore]
		public bool IsRateLimited { get; set; } = false;

		/// <summary>
		/// Indicates the number of seconds to wait before attempting to call the API again when <c> IsRateLimited</c>
		/// is true.
		/// </summary>
		[JsonIgnore]
		public int RetryAfterSeconds { get; set; } = 0;

		/// <summary>
		/// Collection of export records returned from the API call.
		/// </summary>
		public List<PayrollExportRecord> WageData { get; set; } = new List<PayrollExportRecord>();
	}
}