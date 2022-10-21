namespace PickTraceSync.Service
{
	public interface IDateSynchronizationService
	{
		void SynchronizeDate(DateTime date);

		void SynchronizeDateRange(DateTime startDate, DateTime endDate);
	}
}