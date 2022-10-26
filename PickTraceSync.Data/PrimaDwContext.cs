using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PickTraceSync.Domain;
using System.Data;

namespace PickTraceSync.Data
{
	public class PrimaDwContext : DbContext
	{
		public PrimaDwContext() { }
		public PrimaDwContext(DbContextOptions<PrimaDwContext> options) : base(options) { }
		
		 
		public DbSet<PayrollExportRecord> PickTrace_Fact_Payroll_Staging { get; set; }
		public DbSet<PickTracePayrollModel> PickTrace_Fact_Payroll { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			byte scale = 18;
			byte precision = 8;
			

			/* Add scale/precision to PayrollExportRecord entities */

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

		public void BulkInsert(List<PayrollExportRecord> records)
		{
			var tableName = "PickTrace_Fact_Payroll_Staging";
			var table = new DataTable(tableName);

			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.Id), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.CheckpointId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.ProductionRecordId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.OrganizationId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployeeId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployeeNumber), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployeeAltId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployeeTitle), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployeeFullName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.IsH2a), typeof(bool)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployerId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EmployerName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.CrewId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.CrewName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SiteId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SiteName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.LocationId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.LocationName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.LocationAcreage), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.CropId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.CropName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.VarietyId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.VarietyName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.JobId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.JobName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PayPeriod), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.HourlyRate), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.MinimumWage), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PieceRate), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.StartDatetime), typeof(DateTime)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.ShiftStartTime), typeof(DateTime)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.EndDatetime), typeof(DateTime)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.Pieces), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TypeOfTime), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TypeOfWork), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PayStyle), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RegularProductiveSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.NonProductiveSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RestBreakSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.MealPeriodSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DailyDoubletimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DailyOvertimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.WeeklyOvertimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SeventhDayOvertimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SeventhDayDoubletimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TotalSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RegularSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TotalWorkSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SickSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.VacationSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.OtherNonLaborSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RegularProductiveHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.NonProductiveHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RestBreakHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DailyOvertimeHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DailyDoubletimeHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.WeeklyOvertimeHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SeventhDayOvertimeHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SeventhDayDoubletimeHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.AllWorkHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.AllPiecesPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.MakeupPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.StraightPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.SickHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.VacationHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.OtherNonLaborHoursPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RestBreakAverageRate), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.RegularRateOfPay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.OvertimePremium), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DoubletimePremium), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DynamicGrossPayTrackerFinal), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DynamicGrossPayTrackerFinalIncCommission), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.FlcCommission), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.AcceptsPieces), typeof(bool)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PayPerHour), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DeterminedHourlyRate), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.UnitMeasurement), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DynamicGrossPayTrackerFinalRounded), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TotalOvertimePay), typeof(decimal)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.TotalOvertimeSeconds), typeof(int)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.IsOpenTimecard), typeof(bool)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.UpdatedAt), typeof(DateTime)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.IsArchived), typeof(bool)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PackStyleId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.PackStyleName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DeviceId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DeviceName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.WorkflowId), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.WorkflowName), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.ContainerTag), typeof(string)));
			table.Columns.Add(new DataColumn(nameof(PayrollExportRecord.DownloadedAt), typeof(DateTime)));
			
			foreach (var record in records)
			{
				var row = table.NewRow();
				row[nameof(PayrollExportRecord.Id)] = record.Id ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.CheckpointId)] = record.CheckpointId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.ProductionRecordId)] = record.ProductionRecordId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.OrganizationId)] = record.OrganizationId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployeeId)] = record.EmployeeId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployeeNumber)] = record.EmployeeNumber ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployeeAltId)] = record.EmployeeAltId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployeeTitle)] = record.EmployeeTitle ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployeeFullName)] = record.EmployeeFullName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.IsH2a)] = record.IsH2a ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployerId)] = record.EmployerId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EmployerName)] = record.EmployerName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.CrewId)] = record.CrewId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.CrewName)] = record.CrewName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SiteId)] = record.SiteId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SiteName)] = record.SiteName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.LocationId)] = record.LocationId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.LocationName)] = record.LocationName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.LocationAcreage)] = record.LocationAcreage ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.CropId)] = record.CropId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.CropName)] = record.CropName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.VarietyId)] = record.VarietyId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.VarietyName)] = record.VarietyName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.JobId)] = record.JobId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.JobName)] = record.JobName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PayPeriod)] = record.PayPeriod ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.HourlyRate)] = record.HourlyRate ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.MinimumWage)] = record.MinimumWage ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PieceRate)] = record.PieceRate ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.StartDatetime)] = record.StartDatetime ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.ShiftStartTime)] = record.ShiftStartTime ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.EndDatetime)] = record.EndDatetime ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.Pieces)] = record.Pieces ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TypeOfTime)] = record.TypeOfTime ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TypeOfWork)] = record.TypeOfWork ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PayStyle)] = record.PayStyle ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RegularProductiveSeconds)] = record.RegularProductiveSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.NonProductiveSeconds)] = record.NonProductiveSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RestBreakSeconds)] = record.RestBreakSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.MealPeriodSeconds)] = record.MealPeriodSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DailyDoubletimeSeconds)] = record.DailyDoubletimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DailyOvertimeSeconds)] = record.DailyOvertimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.WeeklyOvertimeSeconds)] = record.WeeklyOvertimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SeventhDayOvertimeSeconds)] = record.SeventhDayOvertimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SeventhDayDoubletimeSeconds)] = record.SeventhDayDoubletimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TotalSeconds)] = record.TotalSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RegularSeconds)] = record.RegularSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TotalWorkSeconds)] = record.TotalWorkSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SickSeconds)] = record.SickSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.VacationSeconds)] = record.VacationSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.OtherNonLaborSeconds)] = record.OtherNonLaborSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RegularProductiveHoursPay)] = record.RegularProductiveHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.NonProductiveHoursPay)] = record.NonProductiveHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RestBreakHoursPay)] = record.RestBreakHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DailyOvertimeHoursPay)] = record.DailyOvertimeHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DailyDoubletimeHoursPay)] = record.DailyDoubletimeHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.WeeklyOvertimeHoursPay)] = record.WeeklyOvertimeHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SeventhDayOvertimeHoursPay)] = record.SeventhDayOvertimeHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SeventhDayDoubletimeHoursPay)] = record.SeventhDayDoubletimeHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.AllWorkHoursPay)] = record.AllWorkHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.AllPiecesPay)] = record.AllPiecesPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.MakeupPay)] = record.MakeupPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.StraightPay)] = record.StraightPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.SickHoursPay)] = record.SickHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.VacationHoursPay)] = record.VacationHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.OtherNonLaborHoursPay)] = record.OtherNonLaborHoursPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RestBreakAverageRate)] = record.RestBreakAverageRate ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.RegularRateOfPay)] = record.RegularRateOfPay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.OvertimePremium)] = record.OvertimePremium ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DoubletimePremium)] = record.DoubletimePremium ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DynamicGrossPayTrackerFinal)] = record.DynamicGrossPayTrackerFinal ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DynamicGrossPayTrackerFinalIncCommission)] = record.DynamicGrossPayTrackerFinalIncCommission ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.FlcCommission)] = record.FlcCommission ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.AcceptsPieces)] = record.AcceptsPieces ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PayPerHour)] = record.PayPerHour ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DeterminedHourlyRate)] = record.DeterminedHourlyRate ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.UnitMeasurement)] = record.UnitMeasurement ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DynamicGrossPayTrackerFinalRounded)] = record.DynamicGrossPayTrackerFinalRounded ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TotalOvertimePay)] = record.TotalOvertimePay ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.TotalOvertimeSeconds)] = record.TotalOvertimeSeconds ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.IsOpenTimecard)] = record.IsOpenTimecard ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.UpdatedAt)] = record.UpdatedAt ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.IsArchived)] = record.IsArchived ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PackStyleId)] = record.PackStyleId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.PackStyleName)] = record.PackStyleName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DeviceId)] = record.DeviceId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DeviceName)] = record.DeviceName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.WorkflowId)] = record.WorkflowId ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.WorkflowName)] = record.WorkflowName ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.ContainerTag)] = record.ContainerTag ?? (object)DBNull.Value;
				row[nameof(PayrollExportRecord.DownloadedAt)] = record.DownloadedAt;
				table.Rows.Add(row);
			}

			var connectionString = this.Database.GetDbConnection().ConnectionString;
			using var connection = new SqlConnection(connectionString);
			connection.Open();
			var transaction = connection.BeginTransaction();
			try
			{
				using var sqlBulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.TableLock, transaction);
				sqlBulkCopy.BulkCopyTimeout = 0;
				sqlBulkCopy.BatchSize = 10000;
				sqlBulkCopy.DestinationTableName = tableName;
				sqlBulkCopy.WriteToServer(table);
				transaction.Commit();
			}
			catch(Exception ex)
			{
				transaction.Rollback();
				throw;
			}
			finally
			{
				transaction.Dispose();
				connection.Close();
			}
		} 
	}
}
