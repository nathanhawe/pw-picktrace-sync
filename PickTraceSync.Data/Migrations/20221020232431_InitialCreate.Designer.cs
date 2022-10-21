﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PickTraceSync.Data;

#nullable disable

namespace PickTraceSync.Data.Migrations
{
    [DbContext(typeof(PrimaDwContext))]
    [Migration("20221020232431_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PickTraceSync.Domain.PayrollExportRecord", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AcceptsPieces")
                        .HasColumnType("bit");

                    b.Property<decimal?>("AllPiecesPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("AllWorkHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("CheckpointId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContainerTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CropId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CropName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DailyDoubletimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("DailyDoubletimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("DailyOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("DailyOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("DeterminedHourlyRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DoubletimePremium")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<DateTime>("DownloadedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinal")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinalIncCommission")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinalRounded")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("EmployeeAltId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDatetime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("FlcCommission")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("HourlyRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<bool?>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsH2a")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsOpenTimecard")
                        .HasColumnType("bit");

                    b.Property<string>("JobId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("LocationAcreage")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MakeupPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("MealPeriodSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("MinimumWage")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("NonProductiveHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("NonProductiveSeconds")
                        .HasColumnType("int");

                    b.Property<string>("OrganizationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OtherNonLaborHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("OtherNonLaborSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("OvertimePremium")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("PackStyleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackStyleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PayPerHour")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("PayPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PieceRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("Pieces")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("ProductionRecordId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RegularProductiveHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RegularProductiveSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("RegularRateOfPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RegularSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("RestBreakAverageRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("RestBreakHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RestBreakSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("SeventhDayDoubletimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SeventhDayDoubletimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("SeventhDayOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SeventhDayOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShiftStartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("SickHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SickSeconds")
                        .HasColumnType("int");

                    b.Property<string>("SiteId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDatetime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("StraightPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("TotalOvertimePay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("TotalOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSeconds")
                        .HasColumnType("int");

                    b.Property<int?>("TotalWorkSeconds")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitMeasurement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("VacationHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("VacationSeconds")
                        .HasColumnType("int");

                    b.Property<string>("VarietyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VarietyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("WeeklyOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("WeeklyOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PickTrace_Fact_Payroll_Staging");
                });

            modelBuilder.Entity("PickTraceSync.Domain.PickTracePayrollModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AcceptsPieces")
                        .HasColumnType("bit");

                    b.Property<decimal?>("AllPiecesPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("AllWorkHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("CheckpointId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContainerTag")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrewName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CropId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CropName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DailyDoubletimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("DailyDoubletimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("DailyOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("DailyOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("DeterminedHourlyRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("DeviceId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DoubletimePremium")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<DateTime>("DownloadedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinal")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinalIncCommission")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("DynamicGrossPayTrackerFinalRounded")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("EmployeeAltId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EmployeeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDatetime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("FlcCommission")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("HourlyRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<bool?>("IsArchived")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsH2a")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsOpenTimecard")
                        .HasColumnType("bit");

                    b.Property<string>("JobId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("LocationAcreage")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("LocationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("MakeupPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("MealPeriodSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("MinimumWage")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("NonProductiveHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("NonProductiveSeconds")
                        .HasColumnType("int");

                    b.Property<string>("OrganizationId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OtherNonLaborHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("OtherNonLaborSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("OvertimePremium")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("PackStyleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PackStyleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PayPerHour")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("PayPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PieceRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("Pieces")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<string>("ProductionRecordId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RegularProductiveHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RegularProductiveSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("RegularRateOfPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RegularSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("RestBreakAverageRate")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("RestBreakHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("RestBreakSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("SeventhDayDoubletimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SeventhDayDoubletimeSeconds")
                        .HasColumnType("int");

                    b.Property<decimal?>("SeventhDayOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SeventhDayOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShiftStartTime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("SickHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("SickSeconds")
                        .HasColumnType("int");

                    b.Property<string>("SiteId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDatetime")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("StraightPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<decimal?>("TotalOvertimePay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("TotalOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSeconds")
                        .HasColumnType("int");

                    b.Property<int?>("TotalWorkSeconds")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWork")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnitMeasurement")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("VacationHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("VacationSeconds")
                        .HasColumnType("int");

                    b.Property<string>("VarietyId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VarietyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("WeeklyOvertimeHoursPay")
                        .HasPrecision(18, 8)
                        .HasColumnType("decimal(18,8)");

                    b.Property<int?>("WeeklyOvertimeSeconds")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkflowName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PickTrace_Fact_Payroll");
                });
#pragma warning restore 612, 618
        }
    }
}
