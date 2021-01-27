using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_Policy_Remediation_ControlProcedure_RiskTreatment_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ControlDesignFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlDesignId = table.Column<long>(type: "bigint", nullable: true),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlDesignFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlDesignFindings_ControlDesigns_ControlDesignId",
                        column: x => x.ControlDesignId,
                        principalTable: "ControlDesigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlDesignFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlOperatingTestControlStandards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlOperatingTestId = table.Column<long>(type: "bigint", nullable: true),
                    ControlStandardId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlOperatingTestControlStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTestControlStandards_ControlOperatingTests_ControlOperatingTestId",
                        column: x => x.ControlOperatingTestId,
                        principalTable: "ControlOperatingTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTestControlStandards_ControlStandards_ControlStandardId",
                        column: x => x.ControlStandardId,
                        principalTable: "ControlStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlOperatingTestFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlOperatingTestId = table.Column<long>(type: "bigint", nullable: true),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlOperatingTestFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTestFindings_ControlOperatingTests_ControlOperatingTestId",
                        column: x => x.ControlOperatingTestId,
                        principalTable: "ControlOperatingTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTestFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlProcedures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ControlProcedureId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedureName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlProcedureTypeId = table.Column<int>(type: "int", nullable: true),
                    OperationalFrequencyId = table.Column<int>(type: "int", nullable: true),
                    ActivityCycleId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcedureCategoryId = table.Column<int>(type: "int", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    ProcedureManagerId = table.Column<long>(type: "bigint", nullable: true),
                    ProcedureOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    TestTypeId = table.Column<int>(type: "int", nullable: true),
                    TesterId = table.Column<long>(type: "bigint", nullable: true),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlProcedures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_AbpDynamicPropertyValues_ActivityCycleId",
                        column: x => x.ActivityCycleId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_AbpDynamicPropertyValues_ControlProcedureTypeId",
                        column: x => x.ControlProcedureTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_AbpDynamicPropertyValues_OperationalFrequencyId",
                        column: x => x.OperationalFrequencyId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_AbpDynamicPropertyValues_ProcedureCategoryId",
                        column: x => x.ProcedureCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_AbpDynamicPropertyValues_TestTypeId",
                        column: x => x.TestTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_Employees_ProcedureManagerId",
                        column: x => x.ProcedureManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_Employees_ProcedureOwnerId",
                        column: x => x.ProcedureOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedures_Employees_TesterId",
                        column: x => x.TesterId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlTestBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlOperatingTestId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlTestBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlTestBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlTestBusinessProcess_ControlOperatingTests_ControlOperatingTestId",
                        column: x => x.ControlOperatingTestId,
                        principalTable: "ControlOperatingTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Exceptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ExceptionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestedTillDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessJustification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExceptionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertReviewerId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedTill = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CritcalityId = table.Column<int>(type: "int", nullable: true),
                    ReviewPriorityId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    ExceptionStatusId = table.Column<int>(type: "int", nullable: true),
                    ReviewStatusId = table.Column<int>(type: "int", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    AssetInformationId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
                    SystemApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exceptions_AbpDynamicPropertyValues_CritcalityId",
                        column: x => x.CritcalityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_AbpDynamicPropertyValues_ExceptionStatusId",
                        column: x => x.ExceptionStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_AbpDynamicPropertyValues_ReviewPriorityId",
                        column: x => x.ReviewPriorityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_AbpDynamicPropertyValues_ReviewStatusId",
                        column: x => x.ReviewStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_Employees_ExpertReviewerId",
                        column: x => x.ExpertReviewerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Exceptions_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetingFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    MeetingId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingFindings_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyRelatedControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PolicyRelatedControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyRelatedControls_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyRelatedControls_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Remediations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RemediationPlanId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstimatedCost = table.Column<int>(type: "int", nullable: true),
                    PriorityId = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TreatmentActionId = table.Column<int>(type: "int", nullable: true),
                    RemediationsTypeId = table.Column<int>(type: "int", nullable: true),
                    SubmissionStatusId = table.Column<int>(type: "int", nullable: true),
                    PlanOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    PlanManagerId = table.Column<long>(type: "bigint", nullable: true),
                    PlanStatusId = table.Column<int>(type: "int", nullable: true),
                    MitigationCost = table.Column<int>(type: "int", nullable: true),
                    RemediationActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDateActual = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionDateActual = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
                    RiskManagementsId = table.Column<long>(type: "bigint", nullable: true),
                    ActualCostIncurred = table.Column<int>(type: "int", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remediations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Remediations_AbpDynamicPropertyValues_PlanStatusId",
                        column: x => x.PlanStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_AbpDynamicPropertyValues_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_AbpDynamicPropertyValues_RemediationsTypeId",
                        column: x => x.RemediationsTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_AbpDynamicPropertyValues_SubmissionStatusId",
                        column: x => x.SubmissionStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_AbpDynamicPropertyValues_TreatmentActionId",
                        column: x => x.TreatmentActionId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_Employees_PlanManagerId",
                        column: x => x.PlanManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_Employees_PlanOwnerId",
                        column: x => x.PlanOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Remediations_RiskManagements_RiskManagementsId",
                        column: x => x.RiskManagementsId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlProcedureBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlProcedureId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlProcedureBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlProcedureBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedureBusinessProcess_ControlProcedures_ControlProcedureId",
                        column: x => x.ControlProcedureId,
                        principalTable: "ControlProcedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlProcedureControlStandards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlProcedureId = table.Column<long>(type: "bigint", nullable: true),
                    ControlStandardId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ControlProcedureControlStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlProcedureControlStandards_ControlProcedures_ControlProcedureId",
                        column: x => x.ControlProcedureId,
                        principalTable: "ControlProcedures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlProcedureControlStandards_ControlStandards_ControlStandardId",
                        column: x => x.ControlStandardId,
                        principalTable: "ControlStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionAuditingControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionAuditingControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionAuditingControls_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionAuditingControls_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthoratativeDocumentId = table.Column<long>(type: "bigint", nullable: true),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionAuthoratativeDocuments_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionBusinessUnits_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionCitationLibrarys",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionCitationLibrarys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionCitationLibrarys_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionCitationLibrarys_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionCitations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionCitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionCitations_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionCitations_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionDocuments_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionOrganizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionOrganizations_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionOrganizations_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionRiskManagements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionRiskManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionRiskManagements_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionRiskManagements_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagementExceptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskManagementExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagementExceptions_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagementExceptions_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskTreatmentExceptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskTreatmentId = table.Column<long>(type: "bigint", nullable: true),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskTreatmentExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentExceptions_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentExceptions_RiskTreatments_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "RiskTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionRemediations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    RemediationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionRemediations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExceptionRemediations_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ExceptionRemediations_Remediations_RemediationId",
                        column: x => x.RemediationId,
                        principalTable: "Remediations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceRemediations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
                    RemediationId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ITServiceRemediations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServiceRemediations_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServiceRemediations_Remediations_RemediationId",
                        column: x => x.RemediationId,
                        principalTable: "Remediations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RemediationAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemediationId = table.Column<long>(type: "bigint", nullable: true),
                    AttachmentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Documents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemediationAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemediationAttachments_Remediations_RemediationId",
                        column: x => x.RemediationId,
                        principalTable: "Remediations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RemediationExceptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemediationId = table.Column<long>(type: "bigint", nullable: true),
                    ExceptionId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemediationExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemediationExceptions_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RemediationExceptions_Remediations_RemediationId",
                        column: x => x.RemediationId,
                        principalTable: "Remediations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RemediationRiskManagements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RemediationId = table.Column<long>(type: "bigint", nullable: true),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RemediationRiskManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RemediationRiskManagements_Remediations_RemediationId",
                        column: x => x.RemediationId,
                        principalTable: "Remediations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RemediationRiskManagements_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ControlDesignFindings_ControlDesignId",
                table: "ControlDesignFindings",
                column: "ControlDesignId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlDesignFindings_FindingId",
                table: "ControlDesignFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTestControlStandards_ControlOperatingTestId",
                table: "ControlOperatingTestControlStandards",
                column: "ControlOperatingTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTestControlStandards_ControlStandardId",
                table: "ControlOperatingTestControlStandards",
                column: "ControlStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTestFindings_ControlOperatingTestId",
                table: "ControlOperatingTestFindings",
                column: "ControlOperatingTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTestFindings_FindingId",
                table: "ControlOperatingTestFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedureBusinessProcess_BusinessProcessId",
                table: "ControlProcedureBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedureBusinessProcess_ControlProcedureId",
                table: "ControlProcedureBusinessProcess",
                column: "ControlProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedureControlStandards_ControlProcedureId",
                table: "ControlProcedureControlStandards",
                column: "ControlProcedureId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedureControlStandards_ControlStandardId",
                table: "ControlProcedureControlStandards",
                column: "ControlStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_ActivityCycleId",
                table: "ControlProcedures",
                column: "ActivityCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_BusinessUnitId",
                table: "ControlProcedures",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_CitationId",
                table: "ControlProcedures",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_ControlProcedureTypeId",
                table: "ControlProcedures",
                column: "ControlProcedureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_OperationalFrequencyId",
                table: "ControlProcedures",
                column: "OperationalFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_ProcedureCategoryId",
                table: "ControlProcedures",
                column: "ProcedureCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_ProcedureManagerId",
                table: "ControlProcedures",
                column: "ProcedureManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_ProcedureOwnerId",
                table: "ControlProcedures",
                column: "ProcedureOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_TesterId",
                table: "ControlProcedures",
                column: "TesterId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlProcedures_TestTypeId",
                table: "ControlProcedures",
                column: "TestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlTestBusinessProcess_BusinessProcessId",
                table: "ControlTestBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlTestBusinessProcess_ControlOperatingTestId",
                table: "ControlTestBusinessProcess",
                column: "ControlOperatingTestId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionAuditingControls_CitationId",
                table: "ExceptionAuditingControls",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionAuditingControls_ExceptionId",
                table: "ExceptionAuditingControls",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "ExceptionAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionAuthoratativeDocuments_ExceptionId",
                table: "ExceptionAuthoratativeDocuments",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionBusinessUnits_BusinessUnitId",
                table: "ExceptionBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionBusinessUnits_ExceptionId",
                table: "ExceptionBusinessUnits",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionCitationLibrarys_CitationId",
                table: "ExceptionCitationLibrarys",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionCitationLibrarys_ExceptionId",
                table: "ExceptionCitationLibrarys",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionCitations_CitationId",
                table: "ExceptionCitations",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionCitations_ExceptionId",
                table: "ExceptionCitations",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionDocuments_ExceptionId",
                table: "ExceptionDocuments",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionOrganizations_ExceptionId",
                table: "ExceptionOrganizations",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionOrganizations_LockThreatOrganizationId",
                table: "ExceptionOrganizations",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionRemediations_ExceptionId",
                table: "ExceptionRemediations",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionRemediations_RemediationId",
                table: "ExceptionRemediations",
                column: "RemediationId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionRiskManagements_ExceptionId",
                table: "ExceptionRiskManagements",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ExceptionRiskManagements_RiskManagementId",
                table: "ExceptionRiskManagements",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_AssetInformationId",
                table: "Exceptions",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_BusinessUnitId",
                table: "Exceptions",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_CritcalityId",
                table: "Exceptions",
                column: "CritcalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_EmployeeId",
                table: "Exceptions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_ExceptionStatusId",
                table: "Exceptions",
                column: "ExceptionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_ExpertReviewerId",
                table: "Exceptions",
                column: "ExpertReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_LockThreatOrganizationId",
                table: "Exceptions",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_PolicyManagerId",
                table: "Exceptions",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_ReviewPriorityId",
                table: "Exceptions",
                column: "ReviewPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_ReviewStatusId",
                table: "Exceptions",
                column: "ReviewStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_SystemApplicationId",
                table: "Exceptions",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exceptions_TypeId",
                table: "Exceptions",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceRemediations_ITServiceId",
                table: "ITServiceRemediations",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceRemediations_RemediationId",
                table: "ITServiceRemediations",
                column: "RemediationId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingFindings_FindingId",
                table: "MeetingFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingFindings_MeetingId",
                table: "MeetingFindings",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRelatedControls_CitationId",
                table: "PolicyRelatedControls",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyRelatedControls_PolicyManagerId",
                table: "PolicyRelatedControls",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationAttachments_RemediationId",
                table: "RemediationAttachments",
                column: "RemediationId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationExceptions_ExceptionId",
                table: "RemediationExceptions",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationExceptions_RemediationId",
                table: "RemediationExceptions",
                column: "RemediationId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationRiskManagements_RemediationId",
                table: "RemediationRiskManagements",
                column: "RemediationId");

            migrationBuilder.CreateIndex(
                name: "IX_RemediationRiskManagements_RiskManagementId",
                table: "RemediationRiskManagements",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_PlanManagerId",
                table: "Remediations",
                column: "PlanManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_PlanOwnerId",
                table: "Remediations",
                column: "PlanOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_PlanStatusId",
                table: "Remediations",
                column: "PlanStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_PriorityId",
                table: "Remediations",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_RemediationsTypeId",
                table: "Remediations",
                column: "RemediationsTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_RiskManagementId",
                table: "Remediations",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_RiskManagementsId",
                table: "Remediations",
                column: "RiskManagementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_SubmissionStatusId",
                table: "Remediations",
                column: "SubmissionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Remediations_TreatmentActionId",
                table: "Remediations",
                column: "TreatmentActionId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementExceptions_ExceptionId",
                table: "RiskManagementExceptions",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementExceptions_RiskManagementId",
                table: "RiskManagementExceptions",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentExceptions_ExceptionId",
                table: "RiskTreatmentExceptions",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentExceptions_RiskTreatmentId",
                table: "RiskTreatmentExceptions",
                column: "RiskTreatmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ControlDesignFindings");

            migrationBuilder.DropTable(
                name: "ControlOperatingTestControlStandards");

            migrationBuilder.DropTable(
                name: "ControlOperatingTestFindings");

            migrationBuilder.DropTable(
                name: "ControlProcedureBusinessProcess");

            migrationBuilder.DropTable(
                name: "ControlProcedureControlStandards");

            migrationBuilder.DropTable(
                name: "ControlTestBusinessProcess");

            migrationBuilder.DropTable(
                name: "ExceptionAuditingControls");

            migrationBuilder.DropTable(
                name: "ExceptionAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "ExceptionBusinessUnits");

            migrationBuilder.DropTable(
                name: "ExceptionCitationLibrarys");

            migrationBuilder.DropTable(
                name: "ExceptionCitations");

            migrationBuilder.DropTable(
                name: "ExceptionDocuments");

            migrationBuilder.DropTable(
                name: "ExceptionOrganizations");

            migrationBuilder.DropTable(
                name: "ExceptionRemediations");

            migrationBuilder.DropTable(
                name: "ExceptionRiskManagements");

            migrationBuilder.DropTable(
                name: "ITServiceRemediations");

            migrationBuilder.DropTable(
                name: "MeetingFindings");

            migrationBuilder.DropTable(
                name: "PolicyRelatedControls");

            migrationBuilder.DropTable(
                name: "RemediationAttachments");

            migrationBuilder.DropTable(
                name: "RemediationExceptions");

            migrationBuilder.DropTable(
                name: "RemediationRiskManagements");

            migrationBuilder.DropTable(
                name: "RiskManagementExceptions");

            migrationBuilder.DropTable(
                name: "RiskTreatmentExceptions");

            migrationBuilder.DropTable(
                name: "ControlProcedures");

            migrationBuilder.DropTable(
                name: "Remediations");

            migrationBuilder.DropTable(
                name: "Exceptions");
        }
    }
}
