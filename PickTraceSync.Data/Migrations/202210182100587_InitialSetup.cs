namespace PickTraceSync.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PickTrace_Fact_Payroll",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CheckpointId = c.String(),
                        ProductionRecordId = c.String(),
                        OrganizationId = c.String(),
                        EmployeeId = c.String(),
                        EmployeeNumber = c.Int(),
                        EmployeeAltId = c.String(),
                        EmployeeTitle = c.String(),
                        EmployeeFullName = c.String(),
                        IsH2a = c.Boolean(),
                        EmployerId = c.String(),
                        EmployerName = c.String(),
                        CrewId = c.String(),
                        CrewName = c.String(),
                        SiteId = c.String(),
                        SiteName = c.String(),
                        LocationId = c.String(),
                        LocationName = c.String(),
                        LocationAcreage = c.Decimal(precision: 18, scale: 8),
                        CropId = c.String(),
                        CropName = c.String(),
                        VarietyId = c.String(),
                        VarietyName = c.String(),
                        JobId = c.String(),
                        JobName = c.String(),
                        PayPeriod = c.String(),
                        HourlyRate = c.Decimal(precision: 18, scale: 8),
                        MinimumWage = c.Decimal(precision: 18, scale: 8),
                        PieceRate = c.Decimal(precision: 18, scale: 8),
                        StartDatetime = c.DateTime(precision: 7, storeType: "datetime2"),
                        ShiftStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDatetime = c.DateTime(precision: 7, storeType: "datetime2"),
                        Pieces = c.Decimal(precision: 18, scale: 8),
                        TypeOfTime = c.String(),
                        TypeOfWork = c.String(),
                        PayStyle = c.String(),
                        RegularProductiveSeconds = c.Int(),
                        NonProductiveSeconds = c.Int(),
                        RestBreakSeconds = c.Int(),
                        MealPeriodSeconds = c.Int(),
                        DailyDoubletimeSeconds = c.Int(),
                        DailyOvertimeSeconds = c.Int(),
                        WeeklyOvertimeSeconds = c.Int(),
                        SeventhDayOvertimeSeconds = c.Int(),
                        SeventhDayDoubletimeSeconds = c.Int(),
                        TotalSeconds = c.Int(),
                        RegularSeconds = c.Int(),
                        TotalWorkSeconds = c.Int(),
                        SickSeconds = c.Int(),
                        VacationSeconds = c.Int(),
                        OtherNonLaborSeconds = c.Int(),
                        RegularProductiveHoursPay = c.Decimal(precision: 18, scale: 8),
                        NonProductiveHoursPay = c.Decimal(precision: 18, scale: 8),
                        RestBreakHoursPay = c.Decimal(precision: 18, scale: 8),
                        DailyOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        DailyDoubletimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        WeeklyOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        SeventhDayOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        SeventhDayDoubletimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        AllWorkHoursPay = c.Decimal(precision: 18, scale: 8),
                        AllPiecesPay = c.Decimal(precision: 18, scale: 8),
                        MakeupPay = c.Decimal(precision: 18, scale: 8),
                        StraightPay = c.Decimal(precision: 18, scale: 8),
                        SickHoursPay = c.Decimal(precision: 18, scale: 8),
                        VacationHoursPay = c.Decimal(precision: 18, scale: 8),
                        OtherNonLaborHoursPay = c.Decimal(precision: 18, scale: 8),
                        RestBreakAverageRate = c.Decimal(precision: 18, scale: 8),
                        RegularRateOfPay = c.Decimal(precision: 18, scale: 8),
                        OvertimePremium = c.Decimal(precision: 18, scale: 8),
                        DoubletimePremium = c.Decimal(precision: 18, scale: 8),
                        DynamicGrossPayTrackerFinal = c.Decimal(precision: 18, scale: 8),
                        DynamicGrossPayTrackerFinalIncCommission = c.Decimal(precision: 18, scale: 8),
                        FlcCommission = c.Decimal(precision: 18, scale: 8),
                        AcceptsPieces = c.Boolean(),
                        PayPerHour = c.Decimal(precision: 18, scale: 8),
                        DeterminedHourlyRate = c.Decimal(precision: 18, scale: 8),
                        UnitMeasurement = c.String(),
                        DynamicGrossPayTrackerFinalRounded = c.Decimal(precision: 18, scale: 8),
                        TotalOvertimePay = c.Decimal(precision: 18, scale: 8),
                        TotalOvertimeSeconds = c.Int(),
                        IsOpenTimecard = c.Boolean(),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsArchived = c.Boolean(),
                        PackStyleId = c.String(),
                        PackStyleName = c.String(),
                        DeviceId = c.String(),
                        DeviceName = c.String(),
                        WorkflowId = c.String(),
                        WorkflowName = c.String(),
                        ContainerTag = c.String(),
                        DownloadedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickTrace_Fact_Payroll_Staging",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        CheckpointId = c.String(),
                        ProductionRecordId = c.String(),
                        OrganizationId = c.String(),
                        EmployeeId = c.String(),
                        EmployeeNumber = c.Int(),
                        EmployeeAltId = c.String(),
                        EmployeeTitle = c.String(),
                        EmployeeFullName = c.String(),
                        IsH2a = c.Boolean(),
                        EmployerId = c.String(),
                        EmployerName = c.String(),
                        CrewId = c.String(),
                        CrewName = c.String(),
                        SiteId = c.String(),
                        SiteName = c.String(),
                        LocationId = c.String(),
                        LocationName = c.String(),
                        LocationAcreage = c.Decimal(precision: 18, scale: 8),
                        CropId = c.String(),
                        CropName = c.String(),
                        VarietyId = c.String(),
                        VarietyName = c.String(),
                        JobId = c.String(),
                        JobName = c.String(),
                        PayPeriod = c.String(),
                        HourlyRate = c.Decimal(precision: 18, scale: 8),
                        MinimumWage = c.Decimal(precision: 18, scale: 8),
                        PieceRate = c.Decimal(precision: 18, scale: 8),
                        StartDatetime = c.DateTime(precision: 7, storeType: "datetime2"),
                        ShiftStartTime = c.DateTime(precision: 7, storeType: "datetime2"),
                        EndDatetime = c.DateTime(precision: 7, storeType: "datetime2"),
                        Pieces = c.Decimal(precision: 18, scale: 8),
                        TypeOfTime = c.String(),
                        TypeOfWork = c.String(),
                        PayStyle = c.String(),
                        RegularProductiveSeconds = c.Int(),
                        NonProductiveSeconds = c.Int(),
                        RestBreakSeconds = c.Int(),
                        MealPeriodSeconds = c.Int(),
                        DailyDoubletimeSeconds = c.Int(),
                        DailyOvertimeSeconds = c.Int(),
                        WeeklyOvertimeSeconds = c.Int(),
                        SeventhDayOvertimeSeconds = c.Int(),
                        SeventhDayDoubletimeSeconds = c.Int(),
                        TotalSeconds = c.Int(),
                        RegularSeconds = c.Int(),
                        TotalWorkSeconds = c.Int(),
                        SickSeconds = c.Int(),
                        VacationSeconds = c.Int(),
                        OtherNonLaborSeconds = c.Int(),
                        RegularProductiveHoursPay = c.Decimal(precision: 18, scale: 8),
                        NonProductiveHoursPay = c.Decimal(precision: 18, scale: 8),
                        RestBreakHoursPay = c.Decimal(precision: 18, scale: 8),
                        DailyOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        DailyDoubletimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        WeeklyOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        SeventhDayOvertimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        SeventhDayDoubletimeHoursPay = c.Decimal(precision: 18, scale: 8),
                        AllWorkHoursPay = c.Decimal(precision: 18, scale: 8),
                        AllPiecesPay = c.Decimal(precision: 18, scale: 8),
                        MakeupPay = c.Decimal(precision: 18, scale: 8),
                        StraightPay = c.Decimal(precision: 18, scale: 8),
                        SickHoursPay = c.Decimal(precision: 18, scale: 8),
                        VacationHoursPay = c.Decimal(precision: 18, scale: 8),
                        OtherNonLaborHoursPay = c.Decimal(precision: 18, scale: 8),
                        RestBreakAverageRate = c.Decimal(precision: 18, scale: 8),
                        RegularRateOfPay = c.Decimal(precision: 18, scale: 8),
                        OvertimePremium = c.Decimal(precision: 18, scale: 8),
                        DoubletimePremium = c.Decimal(precision: 18, scale: 8),
                        DynamicGrossPayTrackerFinal = c.Decimal(precision: 18, scale: 8),
                        DynamicGrossPayTrackerFinalIncCommission = c.Decimal(precision: 18, scale: 8),
                        FlcCommission = c.Decimal(precision: 18, scale: 8),
                        AcceptsPieces = c.Boolean(),
                        PayPerHour = c.Decimal(precision: 18, scale: 8),
                        DeterminedHourlyRate = c.Decimal(precision: 18, scale: 8),
                        UnitMeasurement = c.String(),
                        DynamicGrossPayTrackerFinalRounded = c.Decimal(precision: 18, scale: 8),
                        TotalOvertimePay = c.Decimal(precision: 18, scale: 8),
                        TotalOvertimeSeconds = c.Int(),
                        IsOpenTimecard = c.Boolean(),
                        UpdatedAt = c.DateTime(precision: 7, storeType: "datetime2"),
                        IsArchived = c.Boolean(),
                        PackStyleId = c.String(),
                        PackStyleName = c.String(),
                        DeviceId = c.String(),
                        DeviceName = c.String(),
                        WorkflowId = c.String(),
                        WorkflowName = c.String(),
                        ContainerTag = c.String(),
                        DownloadedAt = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);

			CreateStoredProcedure(
				"dbo.PickTrace_Fact_Payroll_MergeFromStaging",
				@"
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
                    TRUNCATE TABLE PRIMADW.dbo.PickTrace_Fact_Payroll_Staging");
		}
        
        public override void Down()
        {
            DropTable("dbo.PickTrace_Fact_Payroll_Staging");
            DropTable("dbo.PickTrace_Fact_Payroll");
            DropStoredProcedure("dbo.PickTrace_Fact_Payroll_MergeFromStaging");
        }
    }
}
