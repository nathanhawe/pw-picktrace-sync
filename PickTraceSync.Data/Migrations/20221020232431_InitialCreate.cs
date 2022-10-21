using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PickTraceSync.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PickTrace_Fact_Payroll",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckpointId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionRecordId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: true),
                    EmployeeAltId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsH2a = table.Column<bool>(type: "bit", nullable: true),
                    EmployerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAcreage = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    CropId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarietyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarietyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    MinimumWage = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    PieceRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    StartDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pieces = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TypeOfTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularProductiveSeconds = table.Column<int>(type: "int", nullable: true),
                    NonProductiveSeconds = table.Column<int>(type: "int", nullable: true),
                    RestBreakSeconds = table.Column<int>(type: "int", nullable: true),
                    MealPeriodSeconds = table.Column<int>(type: "int", nullable: true),
                    DailyDoubletimeSeconds = table.Column<int>(type: "int", nullable: true),
                    DailyOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    WeeklyOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    SeventhDayOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    SeventhDayDoubletimeSeconds = table.Column<int>(type: "int", nullable: true),
                    TotalSeconds = table.Column<int>(type: "int", nullable: true),
                    RegularSeconds = table.Column<int>(type: "int", nullable: true),
                    TotalWorkSeconds = table.Column<int>(type: "int", nullable: true),
                    SickSeconds = table.Column<int>(type: "int", nullable: true),
                    VacationSeconds = table.Column<int>(type: "int", nullable: true),
                    OtherNonLaborSeconds = table.Column<int>(type: "int", nullable: true),
                    RegularProductiveHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    NonProductiveHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RestBreakHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DailyOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DailyDoubletimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    WeeklyOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SeventhDayOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SeventhDayDoubletimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AllWorkHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AllPiecesPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    MakeupPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    StraightPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SickHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    VacationHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    OtherNonLaborHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RestBreakAverageRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RegularRateOfPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    OvertimePremium = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DoubletimePremium = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DynamicGrossPayTrackerFinal = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DynamicGrossPayTrackerFinalIncCommission = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    FlcCommission = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AcceptsPieces = table.Column<bool>(type: "bit", nullable: true),
                    PayPerHour = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DeterminedHourlyRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    UnitMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicGrossPayTrackerFinalRounded = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TotalOvertimePay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TotalOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    IsOpenTimecard = table.Column<bool>(type: "bit", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    PackStyleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackStyleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickTrace_Fact_Payroll", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PickTrace_Fact_Payroll_Staging",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CheckpointId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionRecordId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeNumber = table.Column<int>(type: "int", nullable: true),
                    EmployeeAltId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsH2a = table.Column<bool>(type: "bit", nullable: true),
                    EmployerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrewName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationAcreage = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    CropId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CropName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarietyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VarietyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayPeriod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HourlyRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    MinimumWage = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    PieceRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    StartDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDatetime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pieces = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TypeOfTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeOfWork = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PayStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegularProductiveSeconds = table.Column<int>(type: "int", nullable: true),
                    NonProductiveSeconds = table.Column<int>(type: "int", nullable: true),
                    RestBreakSeconds = table.Column<int>(type: "int", nullable: true),
                    MealPeriodSeconds = table.Column<int>(type: "int", nullable: true),
                    DailyDoubletimeSeconds = table.Column<int>(type: "int", nullable: true),
                    DailyOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    WeeklyOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    SeventhDayOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    SeventhDayDoubletimeSeconds = table.Column<int>(type: "int", nullable: true),
                    TotalSeconds = table.Column<int>(type: "int", nullable: true),
                    RegularSeconds = table.Column<int>(type: "int", nullable: true),
                    TotalWorkSeconds = table.Column<int>(type: "int", nullable: true),
                    SickSeconds = table.Column<int>(type: "int", nullable: true),
                    VacationSeconds = table.Column<int>(type: "int", nullable: true),
                    OtherNonLaborSeconds = table.Column<int>(type: "int", nullable: true),
                    RegularProductiveHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    NonProductiveHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RestBreakHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DailyOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DailyDoubletimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    WeeklyOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SeventhDayOvertimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SeventhDayDoubletimeHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AllWorkHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AllPiecesPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    MakeupPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    StraightPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    SickHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    VacationHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    OtherNonLaborHoursPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RestBreakAverageRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    RegularRateOfPay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    OvertimePremium = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DoubletimePremium = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DynamicGrossPayTrackerFinal = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DynamicGrossPayTrackerFinalIncCommission = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    FlcCommission = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    AcceptsPieces = table.Column<bool>(type: "bit", nullable: true),
                    PayPerHour = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    DeterminedHourlyRate = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    UnitMeasurement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicGrossPayTrackerFinalRounded = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TotalOvertimePay = table.Column<decimal>(type: "decimal(18,8)", precision: 18, scale: 8, nullable: true),
                    TotalOvertimeSeconds = table.Column<int>(type: "int", nullable: true),
                    IsOpenTimecard = table.Column<bool>(type: "bit", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsArchived = table.Column<bool>(type: "bit", nullable: true),
                    PackStyleId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackStyleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkflowName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerTag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DownloadedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PickTrace_Fact_Payroll_Staging", x => x.Id);
                });

            migrationBuilder.Sql(
				@"CREATE PROCEDURE dbo.PickTrace_Fact_Payroll_MergeFromStaging 
                    AS
                    BEGIN
                        -- Update the existing
                        UPDATE
	                        PROD
                        SET
	                         PROD.[Id] = STAGE.[Id]
                            ,PROD.[CheckpointId] = STAGE.[CheckpointId]
                            ,PROD.[ProductionRecordId] = STAGE.[ProductionRecordId]
                            ,PROD.[OrganizationId] = STAGE.[OrganizationId]
                            ,PROD.[EmployeeId] = STAGE.[EmployeeId]
                            ,PROD.[EmployeeNumber] = STAGE.[EmployeeNumber]
                            ,PROD.[EmployeeAltId] = STAGE.[EmployeeAltId]
                            ,PROD.[EmployeeTitle] = STAGE.[EmployeeTitle]
                            ,PROD.[EmployeeFullName] = STAGE.[EmployeeFullName]
                            ,PROD.[IsH2a] = STAGE.[IsH2a]
                            ,PROD.[EmployerId] = STAGE.[EmployerId]
                            ,PROD.[EmployerName] = STAGE.[EmployerName]
                            ,PROD.[CrewId] = STAGE.[CrewId]
                            ,PROD.[CrewName] = STAGE.[CrewName]
                            ,PROD.[SiteId] = STAGE.[SiteId]
                            ,PROD.[SiteName] = STAGE.[SiteName]
                            ,PROD.[LocationId] = STAGE.[LocationId]
                            ,PROD.[LocationName] = STAGE.[LocationName]
                            ,PROD.[LocationAcreage] = STAGE.[LocationAcreage]
                            ,PROD.[CropId] = STAGE.[CropId]
                            ,PROD.[CropName] = STAGE.[CropName]
                            ,PROD.[VarietyId] = STAGE.[VarietyId]
                            ,PROD.[VarietyName] = STAGE.[VarietyName]
                            ,PROD.[JobId] = STAGE.[JobId]
                            ,PROD.[JobName] = STAGE.[JobName]
                            ,PROD.[PayPeriod] = STAGE.[PayPeriod]
                            ,PROD.[HourlyRate] = STAGE.[HourlyRate]
                            ,PROD.[MinimumWage] = STAGE.[MinimumWage]
                            ,PROD.[PieceRate] = STAGE.[PieceRate]
                            ,PROD.[StartDatetime] = STAGE.[StartDatetime]
                            ,PROD.[ShiftStartTime] = STAGE.[ShiftStartTime]
                            ,PROD.[EndDatetime] = STAGE.[EndDatetime]
                            ,PROD.[Pieces] = STAGE.[Pieces]
                            ,PROD.[TypeOfTime] = STAGE.[TypeOfTime]
                            ,PROD.[TypeOfWork] = STAGE.[TypeOfWork]
                            ,PROD.[PayStyle] = STAGE.[PayStyle]
                            ,PROD.[RegularProductiveSeconds] = STAGE.[RegularProductiveSeconds]
                            ,PROD.[NonProductiveSeconds] = STAGE.[NonProductiveSeconds]
                            ,PROD.[RestBreakSeconds] = STAGE.[RestBreakSeconds]
                            ,PROD.[MealPeriodSeconds] = STAGE.[MealPeriodSeconds]
                            ,PROD.[DailyDoubletimeSeconds] = STAGE.[DailyDoubletimeSeconds]
                            ,PROD.[DailyOvertimeSeconds] = STAGE.[DailyOvertimeSeconds]
                            ,PROD.[WeeklyOvertimeSeconds] = STAGE.[WeeklyOvertimeSeconds]
                            ,PROD.[SeventhDayOvertimeSeconds] = STAGE.[SeventhDayOvertimeSeconds]
                            ,PROD.[SeventhDayDoubletimeSeconds] = STAGE.[SeventhDayDoubletimeSeconds]
                            ,PROD.[TotalSeconds] = STAGE.[TotalSeconds]
                            ,PROD.[RegularSeconds] = STAGE.[RegularSeconds]
                            ,PROD.[TotalWorkSeconds] = STAGE.[TotalWorkSeconds]
                            ,PROD.[SickSeconds] = STAGE.[SickSeconds]
                            ,PROD.[VacationSeconds] = STAGE.[VacationSeconds]
                            ,PROD.[OtherNonLaborSeconds] = STAGE.[OtherNonLaborSeconds]
                            ,PROD.[RegularProductiveHoursPay] = STAGE.[RegularProductiveHoursPay]
                            ,PROD.[NonProductiveHoursPay] = STAGE.[NonProductiveHoursPay]
                            ,PROD.[RestBreakHoursPay] = STAGE.[RestBreakHoursPay]
                            ,PROD.[DailyOvertimeHoursPay] = STAGE.[DailyOvertimeHoursPay]
                            ,PROD.[DailyDoubletimeHoursPay] = STAGE.[DailyDoubletimeHoursPay]
                            ,PROD.[WeeklyOvertimeHoursPay] = STAGE.[WeeklyOvertimeHoursPay]
                            ,PROD.[SeventhDayOvertimeHoursPay] = STAGE.[SeventhDayOvertimeHoursPay]
                            ,PROD.[SeventhDayDoubletimeHoursPay] = STAGE.[SeventhDayDoubletimeHoursPay]
                            ,PROD.[AllWorkHoursPay] = STAGE.[AllWorkHoursPay]
                            ,PROD.[AllPiecesPay] = STAGE.[AllPiecesPay]
                            ,PROD.[MakeupPay] = STAGE.[MakeupPay]
                            ,PROD.[StraightPay] = STAGE.[StraightPay]
                            ,PROD.[SickHoursPay] = STAGE.[SickHoursPay]
                            ,PROD.[VacationHoursPay] = STAGE.[VacationHoursPay]
                            ,PROD.[OtherNonLaborHoursPay] = STAGE.[OtherNonLaborHoursPay]
                            ,PROD.[RestBreakAverageRate] = STAGE.[RestBreakAverageRate]
                            ,PROD.[RegularRateOfPay] = STAGE.[RegularRateOfPay]
                            ,PROD.[OvertimePremium] = STAGE.[OvertimePremium]
                            ,PROD.[DoubletimePremium] = STAGE.[DoubletimePremium]
                            ,PROD.[DynamicGrossPayTrackerFinal] = STAGE.[DynamicGrossPayTrackerFinal]
                            ,PROD.[DynamicGrossPayTrackerFinalIncCommission] = STAGE.[DynamicGrossPayTrackerFinalIncCommission]
                            ,PROD.[FlcCommission] = STAGE.[FlcCommission]
                            ,PROD.[AcceptsPieces] = STAGE.[AcceptsPieces]
                            ,PROD.[PayPerHour] = STAGE.[PayPerHour]
                            ,PROD.[DeterminedHourlyRate] = STAGE.[DeterminedHourlyRate]
                            ,PROD.[UnitMeasurement] = STAGE.[UnitMeasurement]
                            ,PROD.[DynamicGrossPayTrackerFinalRounded] = STAGE.[DynamicGrossPayTrackerFinalRounded]
                            ,PROD.[TotalOvertimePay] = STAGE.[TotalOvertimePay]
                            ,PROD.[TotalOvertimeSeconds] = STAGE.[TotalOvertimeSeconds]
                            ,PROD.[IsOpenTimecard] = STAGE.[IsOpenTimecard]
                            ,PROD.[UpdatedAt] = STAGE.[UpdatedAt]
                            ,PROD.[IsArchived] = STAGE.[IsArchived]
                            ,PROD.[PackStyleId] = STAGE.[PackStyleId]
                            ,PROD.[PackStyleName] = STAGE.[PackStyleName]
                            ,PROD.[DeviceId] = STAGE.[DeviceId]
                            ,PROD.[DeviceName] = STAGE.[DeviceName]
                            ,PROD.[WorkflowId] = STAGE.[WorkflowId]
                            ,PROD.[WorkflowName] = STAGE.[WorkflowName]
                            ,PROD.[ContainerTag] = STAGE.[ContainerTag]
                            ,PROD.[DownloadedAt] = STAGE.[DownloadedAt]
                        FROM 
	                        [PRIMADW].[dbo].PickTrace_Fact_Payroll PROD
		                        INNER JOIN PRIMADW.dbo.PickTrace_Fact_Payroll_Staging STAGE ON 
			                        PROD.Id = STAGE.Id
                        -- Insert missing
                        INSERT INTO PRIMADW.dbo.PickTrace_Fact_Payroll
	                        SELECT 
		                         STAGE.[Id]
		                        ,STAGE.[CheckpointId]
		                        ,STAGE.[ProductionRecordId]
		                        ,STAGE.[OrganizationId]
		                        ,STAGE.[EmployeeId]
		                        ,STAGE.[EmployeeNumber]
		                        ,STAGE.[EmployeeAltId]
		                        ,STAGE.[EmployeeTitle]
		                        ,STAGE.[EmployeeFullName]
		                        ,STAGE.[IsH2a]
		                        ,STAGE.[EmployerId]
		                        ,STAGE.[EmployerName]
		                        ,STAGE.[CrewId]
		                        ,STAGE.[CrewName]
		                        ,STAGE.[SiteId]
		                        ,STAGE.[SiteName]
		                        ,STAGE.[LocationId]
		                        ,STAGE.[LocationName]
		                        ,STAGE.[LocationAcreage]
		                        ,STAGE.[CropId]
		                        ,STAGE.[CropName]
		                        ,STAGE.[VarietyId]
		                        ,STAGE.[VarietyName]
		                        ,STAGE.[JobId]
		                        ,STAGE.[JobName]
		                        ,STAGE.[PayPeriod]
		                        ,STAGE.[HourlyRate]
		                        ,STAGE.[MinimumWage]
		                        ,STAGE.[PieceRate]
		                        ,STAGE.[StartDatetime]
		                        ,STAGE.[ShiftStartTime]
		                        ,STAGE.[EndDatetime]
		                        ,STAGE.[Pieces]
		                        ,STAGE.[TypeOfTime]
		                        ,STAGE.[TypeOfWork]
		                        ,STAGE.[PayStyle]
		                        ,STAGE.[RegularProductiveSeconds]
		                        ,STAGE.[NonProductiveSeconds]
		                        ,STAGE.[RestBreakSeconds]
		                        ,STAGE.[MealPeriodSeconds]
		                        ,STAGE.[DailyDoubletimeSeconds]
		                        ,STAGE.[DailyOvertimeSeconds]
		                        ,STAGE.[WeeklyOvertimeSeconds]
		                        ,STAGE.[SeventhDayOvertimeSeconds]
		                        ,STAGE.[SeventhDayDoubletimeSeconds]
		                        ,STAGE.[TotalSeconds]
		                        ,STAGE.[RegularSeconds]
		                        ,STAGE.[TotalWorkSeconds]
		                        ,STAGE.[SickSeconds]
		                        ,STAGE.[VacationSeconds]
		                        ,STAGE.[OtherNonLaborSeconds]
		                        ,STAGE.[RegularProductiveHoursPay]
		                        ,STAGE.[NonProductiveHoursPay]
		                        ,STAGE.[RestBreakHoursPay]
		                        ,STAGE.[DailyOvertimeHoursPay]
		                        ,STAGE.[DailyDoubletimeHoursPay]
		                        ,STAGE.[WeeklyOvertimeHoursPay]
		                        ,STAGE.[SeventhDayOvertimeHoursPay]
		                        ,STAGE.[SeventhDayDoubletimeHoursPay]
		                        ,STAGE.[AllWorkHoursPay]
		                        ,STAGE.[AllPiecesPay]
		                        ,STAGE.[MakeupPay]
		                        ,STAGE.[StraightPay]
		                        ,STAGE.[SickHoursPay]
		                        ,STAGE.[VacationHoursPay]
		                        ,STAGE.[OtherNonLaborHoursPay]
		                        ,STAGE.[RestBreakAverageRate]
		                        ,STAGE.[RegularRateOfPay]
		                        ,STAGE.[OvertimePremium]
		                        ,STAGE.[DoubletimePremium]
		                        ,STAGE.[DynamicGrossPayTrackerFinal]
		                        ,STAGE.[DynamicGrossPayTrackerFinalIncCommission]
		                        ,STAGE.[FlcCommission]
		                        ,STAGE.[AcceptsPieces]
		                        ,STAGE.[PayPerHour]
		                        ,STAGE.[DeterminedHourlyRate]
		                        ,STAGE.[UnitMeasurement]
		                        ,STAGE.[DynamicGrossPayTrackerFinalRounded]
		                        ,STAGE.[TotalOvertimePay]
		                        ,STAGE.[TotalOvertimeSeconds]
		                        ,STAGE.[IsOpenTimecard]
		                        ,STAGE.[UpdatedAt]
		                        ,STAGE.[IsArchived]
                                ,STAGE.[PackStyleId]
                                ,STAGE.[PackStyleName]
                                ,STAGE.[DeviceId]
                                ,STAGE.[DeviceName]
                                ,STAGE.[WorkflowId]
                                ,STAGE.[WorkflowName]
                                ,STAGE.[ContainerTag]
		                        ,STAGE.[DownloadedAt]
	                        FROM [PRIMADW].[dbo].PickTrace_Fact_Payroll_Staging STAGE
		                        LEFT JOIN PRIMADW.dbo.PickTrace_Fact_Payroll PROD ON
			                        PROD.Id = STAGE.Id
	                        WHERE PROD.Id IS NULL
                        -- Truncate the staging table
                        TRUNCATE TABLE PRIMADW.dbo.PickTrace_Fact_Payroll_Staging
                    END
                    GO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PickTrace_Fact_Payroll");

            migrationBuilder.DropTable(
                name: "PickTrace_Fact_Payroll_Staging");

            migrationBuilder.Sql("DROP PROCEDURE dbo.PickTrace_Fact_Payroll_MergeFromStaging");
        }
    }
}
