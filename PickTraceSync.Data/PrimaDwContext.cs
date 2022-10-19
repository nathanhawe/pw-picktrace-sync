using PickTraceSync.Domain;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PickTraceSync.Data
{
	public class PrimaDwContext : DbContext
	{
		/// <summary>
		/// Default constructor will use the local SQL express entity for development.  Production will pass a connection
		/// string to the alternate constructor.
		/// </summary>
		public PrimaDwContext() : base("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PRIMADW") { }
		public PrimaDwContext(string connectionString) : base(connectionString) { }
		
		 
		public DbSet<PayrollExportRecord> PickTrace_Fact_Payroll_Staging { get; set; }
		public DbSet<PickTracePayrollModel> PickTrace_Fact_Payroll { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			byte scale = 18;
			byte precision = 8;

			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

			/* Add scale/precision to PayrollExportRecord entities */
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.StartDatetime).HasColumnType("datetime2");
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.ShiftStartTime).HasColumnType("datetime2");
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.EndDatetime).HasColumnType("datetime2");
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.UpdatedAt).HasColumnType("datetime2");
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DownloadedAt).HasColumnType("datetime2");

			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.LocationAcreage).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.HourlyRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.MinimumWage).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.PieceRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.Pieces).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.RegularProductiveHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.NonProductiveHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.RestBreakHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DailyOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DailyDoubletimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.WeeklyOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.SeventhDayOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.SeventhDayDoubletimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.AllWorkHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.AllPiecesPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.MakeupPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.StraightPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.SickHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.VacationHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.OtherNonLaborHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.RestBreakAverageRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.RegularRateOfPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.OvertimePremium).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DoubletimePremium).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DynamicGrossPayTrackerFinal).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DynamicGrossPayTrackerFinalIncCommission).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.FlcCommission).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.PayPerHour).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DeterminedHourlyRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.DynamicGrossPayTrackerFinalRounded).HasPrecision(scale, precision);
			modelBuilder.Entity<PayrollExportRecord>().Property(x => x.TotalOvertimePay).HasPrecision(scale, precision);

			/* Add scale/precision to PickTracePayrollModel entities */
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.StartDatetime).HasColumnType("datetime2");
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.ShiftStartTime).HasColumnType("datetime2");
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.EndDatetime).HasColumnType("datetime2");
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.UpdatedAt).HasColumnType("datetime2");
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DownloadedAt).HasColumnType("datetime2");

			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.LocationAcreage).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.HourlyRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.MinimumWage).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.PieceRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.Pieces).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.RegularProductiveHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.NonProductiveHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.RestBreakHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DailyOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DailyDoubletimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.WeeklyOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.SeventhDayOvertimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.SeventhDayDoubletimeHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.AllWorkHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.AllPiecesPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.MakeupPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.StraightPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.SickHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.VacationHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.OtherNonLaborHoursPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.RestBreakAverageRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.RegularRateOfPay).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.OvertimePremium).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DoubletimePremium).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DynamicGrossPayTrackerFinal).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DynamicGrossPayTrackerFinalIncCommission).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.FlcCommission).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.PayPerHour).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DeterminedHourlyRate).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.DynamicGrossPayTrackerFinalRounded).HasPrecision(scale, precision);
			modelBuilder.Entity<PickTracePayrollModel>().Property(x => x.TotalOvertimePay).HasPrecision(scale, precision);


			base.OnModelCreating(modelBuilder);
		}
	}
}
