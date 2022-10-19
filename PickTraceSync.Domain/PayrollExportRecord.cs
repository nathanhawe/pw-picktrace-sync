﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace PickTraceSync.Domain
{
	[Table("PickTrace_Fact_Payroll_Staging")]
	public class PayrollExportRecord
	{
		public string? Id { get; set; }
		public string? CheckpointId { get; set; }
		public string? ProductionRecordId { get; set; }
		public string? OrganizationId { get; set; }
		public string? EmployeeId { get; set; }
		public int? EmployeeNumber { get; set; }
		public string? EmployeeAltId { get; set; }
		public string? EmployeeTitle { get; set; }
		public string? EmployeeFullName { get; set; }
		public bool? IsH2a { get; set; }
		public string? EmployerId { get; set; }
		public string? EmployerName { get; set; }
		public string? CrewId { get; set; }
		public string? CrewName { get; set; }
		public string? SiteId { get; set; }
		public string? SiteName { get; set; }
		public string? LocationId { get; set; }
		public string? LocationName { get; set; }
		public decimal? LocationAcreage { get; set; }
		public string? CropId { get; set; }
		public string? CropName { get; set; }
		public string? VarietyId { get; set; }
		public string? VarietyName { get; set; }
		public string? JobId { get; set; }
		public string? JobName { get; set; }
		public string? PayPeriod { get; set; }
		public decimal? HourlyRate { get; set; }
		public decimal? MinimumWage { get; set; }
		public decimal? PieceRate { get; set; }
		public DateTime? StartDatetime { get; set; }
		public DateTime? ShiftStartTime { get; set; }
		public DateTime? EndDatetime { get; set; }
		public decimal? Pieces { get; set; }
		public string? TypeOfTime { get; set; }
		public string? TypeOfWork { get; set; }
		public string? PayStyle { get; set; }
		public int? RegularProductiveSeconds { get; set; }
		public int? NonProductiveSeconds { get; set; }
		public int? RestBreakSeconds { get; set; }
		public int? MealPeriodSeconds { get; set; }
		public int? DailyDoubletimeSeconds { get; set; }
		public int? DailyOvertimeSeconds { get; set; }
		public int? WeeklyOvertimeSeconds { get; set; }
		public int? SeventhDayOvertimeSeconds { get; set; }
		public int? SeventhDayDoubletimeSeconds { get; set; }
		public int? TotalSeconds { get; set; }
		public int? RegularSeconds { get; set; }
		public int? TotalWorkSeconds { get; set; }
		public int? SickSeconds { get; set; }
		public int? VacationSeconds { get; set; }
		public int? OtherNonLaborSeconds { get; set; }
		public decimal? RegularProductiveHoursPay { get; set; }
		public decimal? NonProductiveHoursPay { get; set; }
		public decimal? RestBreakHoursPay { get; set; }
		public decimal? DailyOvertimeHoursPay { get; set; }
		public decimal? DailyDoubletimeHoursPay { get; set; }
		public decimal? WeeklyOvertimeHoursPay { get; set; }
		public decimal? SeventhDayOvertimeHoursPay { get; set; }
		public decimal? SeventhDayDoubletimeHoursPay { get; set; }
		public decimal? AllWorkHoursPay { get; set; }
		public decimal? AllPiecesPay { get; set; }
		public decimal? MakeupPay { get; set; }
		public decimal? StraightPay { get; set; }
		public decimal? SickHoursPay { get; set; }
		public decimal? VacationHoursPay { get; set; }
		public decimal? OtherNonLaborHoursPay { get; set; }
		public decimal? RestBreakAverageRate { get; set; }
		public decimal? RegularRateOfPay { get; set; }
		public decimal? OvertimePremium { get; set; }
		public decimal? DoubletimePremium { get; set; }
		public decimal? DynamicGrossPayTrackerFinal { get; set; }
		public decimal? DynamicGrossPayTrackerFinalIncCommission { get; set; }
		public decimal? FlcCommission { get; set; }
		public bool? AcceptsPieces { get; set; }
		public decimal? PayPerHour { get; set; }
		public decimal? DeterminedHourlyRate { get; set; }
		public string? UnitMeasurement { get; set; }
		public decimal? DynamicGrossPayTrackerFinalRounded { get; set; }
		public decimal? TotalOvertimePay { get; set; }
		public int? TotalOvertimeSeconds { get; set; }
		public bool? IsOpenTimecard { get; set; }
		public DateTime? UpdatedAt { get; set; }
		public bool? IsArchived { get; set; }
		public string? PackStyleId { get; set; }
		public string? PackStyleName { get; set; }
		public string? DeviceId { get; set; }
		public string? DeviceName { get; set; }
		public string? WorkflowId { get; set; }
		public string? WorkflowName { get; set; }
		public string? ContainerTag { get; set; }

				
		[JsonIgnore]
		public DateTime DownloadedAt
		{
			get
			{
				return DateTime.UtcNow;
			}
			set
			{

			}
		}
	}
}