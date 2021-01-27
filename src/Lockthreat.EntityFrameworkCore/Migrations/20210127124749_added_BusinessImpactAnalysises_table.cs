using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_BusinessImpactAnalysises_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessImpactAnalysises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    BIAId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    BIATitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIAOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIAManagerId = table.Column<long>(type: "bigint", nullable: true),
                    RiskCategoryId = table.Column<int>(type: "int", nullable: true),
                    NextReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Criticality = table.Column<int>(type: "int", nullable: false),
                    BIATypeId = table.Column<int>(type: "int", nullable: true),
                    RiskLikelihoodId = table.Column<int>(type: "int", nullable: true),
                    NextEvaluation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskImpactId = table.Column<int>(type: "int", nullable: true),
                    PersistenceId = table.Column<int>(type: "int", nullable: true),
                    EvaluationFrequency = table.Column<int>(type: "int", nullable: true),
                    EvaluationIRR = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VelocityId = table.Column<int>(type: "int", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: true),
                    ResidualRiskId = table.Column<int>(type: "int", nullable: true),
                    ExpectedLoss = table.Column<int>(type: "int", nullable: true),
                    InherentRiskId = table.Column<int>(type: "int", nullable: true),
                    RiskTreatmentSelectedId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_BusinessImpactAnalysises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_BIATypeId",
                        column: x => x.BIATypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_DurationId",
                        column: x => x.DurationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_InherentRiskId",
                        column: x => x.InherentRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_PersistenceId",
                        column: x => x.PersistenceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_ResidualRiskId",
                        column: x => x.ResidualRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_RiskCategoryId",
                        column: x => x.RiskCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_RiskImpactId",
                        column: x => x.RiskImpactId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_RiskLikelihoodId",
                        column: x => x.RiskLikelihoodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_RiskTreatmentSelectedId",
                        column: x => x.RiskTreatmentSelectedId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_AbpDynamicPropertyValues_VelocityId",
                        column: x => x.VelocityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_Employees_BIAManagerId",
                        column: x => x.BIAManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_Employees_BIAOwnerId",
                        column: x => x.BIAOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessImpactAnalysises_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_EmployeeServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeServices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IDGenerators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    value = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IDGenerators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IssueManagements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    IssueId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccuranceDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReportedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MeetingId = table.Column<int>(type: "int", nullable: true),
                    MeetingId1 = table.Column<long>(type: "bigint", nullable: true),
                    IssueCategoryId = table.Column<int>(type: "int", nullable: true),
                    RiskAssessmentRequired = table.Column<bool>(type: "bit", nullable: false),
                    ReporterId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    ActionTypes = table.Column<int>(type: "int", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Completed = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletedById = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssignedToId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IssueManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssueManagements_AbpDynamicPropertyValues_IssueCategoryId",
                        column: x => x.IssueCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManagements_Employees_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManagements_Employees_CompletedById",
                        column: x => x.CompletedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManagements_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManagements_Employees_ReporterId",
                        column: x => x.ReporterId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManagements_Meetings_MeetingId1",
                        column: x => x.MeetingId1,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIABusinessProcesses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIABusinessProcesses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIABusinessProcesses_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIABusinessProcesses_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIAExceptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIAExceptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIAExceptions_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIAExceptions_Exceptions_ExceptionId",
                        column: x => x.ExceptionId,
                        principalTable: "Exceptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIAFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIAFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIAFindings_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIAFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIAInformationAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
                    AssetInformationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIAInformationAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIAInformationAssets_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIAInformationAssets_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIAInternalControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
                    InternalControlId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIAInternalControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIAInternalControls_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIAInternalControls_InternalControls_InternalControlId",
                        column: x => x.InternalControlId,
                        principalTable: "InternalControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIAStrategicObjectives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessImpactAnalysisId = table.Column<long>(type: "bigint", nullable: true),
                    StrategicObjectiveId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BIAStrategicObjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BIAStrategicObjectives_BusinessImpactAnalysises_BusinessImpactAnalysisId",
                        column: x => x.BusinessImpactAnalysisId,
                        principalTable: "BusinessImpactAnalysises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BIAStrategicObjectives_StrategicObjectives_StrategicObjectiveId",
                        column: x => x.StrategicObjectiveId,
                        principalTable: "StrategicObjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IssueManageMentProjects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueManagementId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IssueManageMentProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IssueManageMentProjects_IssueManagements_IssueManagementId",
                        column: x => x.IssueManagementId,
                        principalTable: "IssueManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IssueManageMentProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BIABusinessProcesses_BusinessImpactAnalysisId",
                table: "BIABusinessProcesses",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIABusinessProcesses_BusinessProcessId",
                table: "BIABusinessProcesses",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAExceptions_BusinessImpactAnalysisId",
                table: "BIAExceptions",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAExceptions_ExceptionId",
                table: "BIAExceptions",
                column: "ExceptionId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAFindings_BusinessImpactAnalysisId",
                table: "BIAFindings",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAFindings_FindingId",
                table: "BIAFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAInformationAssets_AssetInformationId",
                table: "BIAInformationAssets",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAInformationAssets_BusinessImpactAnalysisId",
                table: "BIAInformationAssets",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAInternalControls_BusinessImpactAnalysisId",
                table: "BIAInternalControls",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAInternalControls_InternalControlId",
                table: "BIAInternalControls",
                column: "InternalControlId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAStrategicObjectives_BusinessImpactAnalysisId",
                table: "BIAStrategicObjectives",
                column: "BusinessImpactAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_BIAStrategicObjectives_StrategicObjectiveId",
                table: "BIAStrategicObjectives",
                column: "StrategicObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_BIAManagerId",
                table: "BusinessImpactAnalysises",
                column: "BIAManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_BIAOwnerId",
                table: "BusinessImpactAnalysises",
                column: "BIAOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_BIATypeId",
                table: "BusinessImpactAnalysises",
                column: "BIATypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_BusinessUnitId",
                table: "BusinessImpactAnalysises",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_DurationId",
                table: "BusinessImpactAnalysises",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_InherentRiskId",
                table: "BusinessImpactAnalysises",
                column: "InherentRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_LockThreatOrganizationId",
                table: "BusinessImpactAnalysises",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_PersistenceId",
                table: "BusinessImpactAnalysises",
                column: "PersistenceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_ResidualRiskId",
                table: "BusinessImpactAnalysises",
                column: "ResidualRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_RiskCategoryId",
                table: "BusinessImpactAnalysises",
                column: "RiskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_RiskImpactId",
                table: "BusinessImpactAnalysises",
                column: "RiskImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_RiskLikelihoodId",
                table: "BusinessImpactAnalysises",
                column: "RiskLikelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_RiskTreatmentSelectedId",
                table: "BusinessImpactAnalysises",
                column: "RiskTreatmentSelectedId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessImpactAnalysises_VelocityId",
                table: "BusinessImpactAnalysises",
                column: "VelocityId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServices_BusinessServiceId",
                table: "EmployeeServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeServices_EmployeeId",
                table: "EmployeeServices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManageMentProjects_IssueManagementId",
                table: "IssueManageMentProjects",
                column: "IssueManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManageMentProjects_ProjectId",
                table: "IssueManageMentProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_AssignedToId",
                table: "IssueManagements",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_CompletedById",
                table: "IssueManagements",
                column: "CompletedById");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_IssueCategoryId",
                table: "IssueManagements",
                column: "IssueCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_MeetingId1",
                table: "IssueManagements",
                column: "MeetingId1");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_OwnerId",
                table: "IssueManagements",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueManagements_ReporterId",
                table: "IssueManagements",
                column: "ReporterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIABusinessProcesses");

            migrationBuilder.DropTable(
                name: "BIAExceptions");

            migrationBuilder.DropTable(
                name: "BIAFindings");

            migrationBuilder.DropTable(
                name: "BIAInformationAssets");

            migrationBuilder.DropTable(
                name: "BIAInternalControls");

            migrationBuilder.DropTable(
                name: "BIAStrategicObjectives");

            migrationBuilder.DropTable(
                name: "EmployeeServices");

            migrationBuilder.DropTable(
                name: "IDGenerators");

            migrationBuilder.DropTable(
                name: "IssueManageMentProjects");

            migrationBuilder.DropTable(
                name: "BusinessImpactAnalysises");

            migrationBuilder.DropTable(
                name: "IssueManagements");
        }
    }
}
