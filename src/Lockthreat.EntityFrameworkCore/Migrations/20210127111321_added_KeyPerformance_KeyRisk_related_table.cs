using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_KeyPerformance_KeyRisk_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractRiskTreatments_RiskTreatment_RiskTreatmentId",
                table: "ContractRiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_MitigationStatusId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualImpactRatingId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualLikelihoodRatingId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_TreatmentActionId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_Employees_MitigationOwnerId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_Employees_OwnerId",
                table: "RiskTreatment");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatment_RiskManagements_RiskManagementId",
                table: "RiskTreatment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RiskTreatment",
                table: "RiskTreatment");

            migrationBuilder.RenameTable(
                name: "RiskTreatment",
                newName: "RiskTreatments");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_TreatmentActionId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_TreatmentActionId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_RiskManagementId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_RiskManagementId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_ResidualLikelihoodRatingId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_ResidualLikelihoodRatingId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_ResidualImpactRatingId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_ResidualImpactRatingId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_OwnerId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_MitigationStatusId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_MitigationStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatment_MitigationOwnerId",
                table: "RiskTreatments",
                newName: "IX_RiskTreatments_MitigationOwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiskTreatments",
                table: "RiskTreatments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CitationQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CitationQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitationQuestions_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitationQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContactCyberAwarenessScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<long>(type: "bigint", nullable: true),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContactCyberAwarenessScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactCyberAwarenessScores_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContactCyberAwarenessScores_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ContractAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractAttachments_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlStandards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ControlId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceVersion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCFCId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlStandardId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameworkObjectiveId = table.Column<int>(type: "int", nullable: true),
                    ControlClassificationId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    ControlFrequencyId = table.Column<int>(type: "int", nullable: true),
                    FrequencyTypeId = table.Column<int>(type: "int", nullable: true),
                    ControlCategoryId = table.Column<int>(type: "int", nullable: true),
                    ControlAreaId = table.Column<int>(type: "int", nullable: true),
                    ControlObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomApplicability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestingProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SampleSize = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ControlStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_ControlAreaId",
                        column: x => x.ControlAreaId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_ControlCategoryId",
                        column: x => x.ControlCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_ControlClassificationId",
                        column: x => x.ControlClassificationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_ControlFrequencyId",
                        column: x => x.ControlFrequencyId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_FrameworkObjectiveId",
                        column: x => x.FrameworkObjectiveId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_FrequencyTypeId",
                        column: x => x.FrequencyTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandards_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScoreEmployees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CyberAwarenessScoreEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreEmployees_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScoreQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CyberAwarenessScoreQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreQuestions_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreQuestions_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    KeyPerformanceIndicatorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyPerformanceIndicatorTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    FrequencyId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_KeyPerformanceIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicators_AbpDynamicPropertyValues_FrequencyId",
                        column: x => x.FrequencyId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicators_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicators_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicators_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyRiskIndicators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    KeyRiskIndicatorsId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    KeyRiskIndicatorTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_KeyRiskIndicators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyRiskIndicators_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyRiskIndicators_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyManagers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    PolicyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyTypeId = table.Column<int>(type: "int", nullable: true),
                    RelatedPoliciesId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyStatusId = table.Column<int>(type: "int", nullable: true),
                    PolicyOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyManagersId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Purpose = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OriginalPolicy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PolicyDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovalById = table.Column<long>(type: "bigint", nullable: true),
                    ApproverComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprovedBySignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalReviewerId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewerNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalReviewerSignature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpcomingReview = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EffectiveTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ScheduledReview = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_PolicyManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_AbpDynamicPropertyValues_PolicyStatusId",
                        column: x => x.PolicyStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_AbpDynamicPropertyValues_PolicyTypeId",
                        column: x => x.PolicyTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_ApprovalById",
                        column: x => x.ApprovalById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_FinalReviewerId",
                        column: x => x.FinalReviewerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_PolicyManagersId",
                        column: x => x.PolicyManagersId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_Employees_PolicyOwnerId",
                        column: x => x.PolicyOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyManagers_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthoratativeDocumentId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_QuestionAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionAuthoratativeDocuments_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagementAssetInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_RiskManagementAssetInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagementAssetInformations_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagementAssetInformations_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagementBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_RiskManagementBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagementBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagementBusinessProcess_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagementFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_RiskManagementFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagementFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagementFindings_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskTreatmentAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskTreatmentId = table.Column<long>(type: "bigint", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_RiskTreatmentAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentAttachments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentAttachments_RiskTreatments_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "RiskTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskTreatmentContracts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RiskTreatmentId = table.Column<long>(type: "bigint", nullable: true),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_RiskTreatmentContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentContracts_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentContracts_RiskTreatments_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "RiskTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskTreatmentVendors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    RiskTreatmentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_RiskTreatmentVendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentVendors_RiskTreatments_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "RiskTreatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatmentVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CitationControlStandards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CitationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CitationControlStandards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CitationControlStandards_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CitationControlStandards_ControlStandards_ControlStandardId",
                        column: x => x.ControlStandardId,
                        principalTable: "ControlStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlStandardCitations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ControlStandardId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ControlStandardCitations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlStandardCitations_Citations_CitationId",
                        column: x => x.CitationId,
                        principalTable: "Citations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlStandardCitations_ControlStandards_ControlStandardId",
                        column: x => x.ControlStandardId,
                        principalTable: "ControlStandards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicatorAdministrators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerformanceIndicatorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_KeyPerformanceIndicatorAdministrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicatorAdministrators_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicatorAdministrators_KeyPerformanceIndicators_KeyPerformanceIndicatorId",
                        column: x => x.KeyPerformanceIndicatorId,
                        principalTable: "KeyPerformanceIndicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyPerformanceIndicatorBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyPerformanceIndicatorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_KeyPerformanceIndicatorBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicatorBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyPerformanceIndicatorBusinessUnits_KeyPerformanceIndicators_KeyPerformanceIndicatorId",
                        column: x => x.KeyPerformanceIndicatorId,
                        principalTable: "KeyPerformanceIndicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KeyRiskIndicatorBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    KeyRiskIndicatorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_KeyRiskIndicatorBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KeyRiskIndicatorBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KeyRiskIndicatorBusinessUnits_KeyRiskIndicators_KeyRiskIndicatorId",
                        column: x => x.KeyRiskIndicatorId,
                        principalTable: "KeyRiskIndicators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
                    AuthoratativeDocumentsId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_PolicyAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentsId",
                        column: x => x.AuthoratativeDocumentsId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyAuthoratativeDocuments_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyDistributions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
                    PolicyDistributionMethod = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PolicyDistributions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyDistributions_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyImpactedOranizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_PolicyImpactedOranizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyImpactedOranizations_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyImpactedOranizations_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PolicyReviewers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyManagerId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_PolicyReviewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PolicyReviewers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PolicyReviewers_PolicyManagers_PolicyManagerId",
                        column: x => x.PolicyManagerId,
                        principalTable: "PolicyManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitationControlStandards_CitationId",
                table: "CitationControlStandards",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_CitationControlStandards_ControlStandardId",
                table: "CitationControlStandards",
                column: "ControlStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_CitationQuestions_CitationId",
                table: "CitationQuestions",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_CitationQuestions_QuestionId",
                table: "CitationQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactCyberAwarenessScores_ContactId",
                table: "ContactCyberAwarenessScores",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactCyberAwarenessScores_CyberAwarenessScoreId",
                table: "ContactCyberAwarenessScores",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractAttachments_ContractId",
                table: "ContractAttachments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandardCitations_CitationId",
                table: "ControlStandardCitations",
                column: "CitationId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandardCitations_ControlStandardId",
                table: "ControlStandardCitations",
                column: "ControlStandardId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_ControlAreaId",
                table: "ControlStandards",
                column: "ControlAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_ControlCategoryId",
                table: "ControlStandards",
                column: "ControlCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_ControlClassificationId",
                table: "ControlStandards",
                column: "ControlClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_ControlFrequencyId",
                table: "ControlStandards",
                column: "ControlFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_FrameworkObjectiveId",
                table: "ControlStandards",
                column: "FrameworkObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_FrequencyTypeId",
                table: "ControlStandards",
                column: "FrequencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlStandards_TypeId",
                table: "ControlStandards",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreEmployees_CyberAwarenessScoreId",
                table: "CyberAwarenessScoreEmployees",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreEmployees_EmployeeId",
                table: "CyberAwarenessScoreEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreQuestions_CyberAwarenessScoreId",
                table: "CyberAwarenessScoreQuestions",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreQuestions_QuestionId",
                table: "CyberAwarenessScoreQuestions",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicatorAdministrators_EmployeeId",
                table: "KeyPerformanceIndicatorAdministrators",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicatorAdministrators_KeyPerformanceIndicatorId",
                table: "KeyPerformanceIndicatorAdministrators",
                column: "KeyPerformanceIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicatorBusinessUnits_BusinessUnitId",
                table: "KeyPerformanceIndicatorBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicatorBusinessUnits_KeyPerformanceIndicatorId",
                table: "KeyPerformanceIndicatorBusinessUnits",
                column: "KeyPerformanceIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicators_EmployeeId",
                table: "KeyPerformanceIndicators",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicators_FrequencyId",
                table: "KeyPerformanceIndicators",
                column: "FrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicators_LockThreatOrganizationId",
                table: "KeyPerformanceIndicators",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyPerformanceIndicators_StatusId",
                table: "KeyPerformanceIndicators",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyRiskIndicatorBusinessUnits_BusinessUnitId",
                table: "KeyRiskIndicatorBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyRiskIndicatorBusinessUnits_KeyRiskIndicatorId",
                table: "KeyRiskIndicatorBusinessUnits",
                column: "KeyRiskIndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyRiskIndicators_LockThreatOrganizationId",
                table: "KeyRiskIndicators",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_KeyRiskIndicators_StatusId",
                table: "KeyRiskIndicators",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyAuthoratativeDocuments_AuthoratativeDocumentsId",
                table: "PolicyAuthoratativeDocuments",
                column: "AuthoratativeDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyAuthoratativeDocuments_PolicyManagerId",
                table: "PolicyAuthoratativeDocuments",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyDistributions_PolicyManagerId",
                table: "PolicyDistributions",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyImpactedOranizations_LockThreatOrganizationId",
                table: "PolicyImpactedOranizations",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyImpactedOranizations_PolicyManagerId",
                table: "PolicyImpactedOranizations",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_ApprovalById",
                table: "PolicyManagers",
                column: "ApprovalById");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_FinalReviewerId",
                table: "PolicyManagers",
                column: "FinalReviewerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_LockThreatOrganizationId",
                table: "PolicyManagers",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyManagersId",
                table: "PolicyManagers",
                column: "PolicyManagersId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyOwnerId",
                table: "PolicyManagers",
                column: "PolicyOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyStatusId",
                table: "PolicyManagers",
                column: "PolicyStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyManagers_PolicyTypeId",
                table: "PolicyManagers",
                column: "PolicyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyReviewers_EmployeeId",
                table: "PolicyReviewers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_PolicyReviewers_PolicyManagerId",
                table: "PolicyReviewers",
                column: "PolicyManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "QuestionAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionAuthoratativeDocuments_QuestionId",
                table: "QuestionAuthoratativeDocuments",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementAssetInformations_AssetInformationId",
                table: "RiskManagementAssetInformations",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementAssetInformations_RiskManagementId",
                table: "RiskManagementAssetInformations",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementBusinessProcess_BusinessProcessId",
                table: "RiskManagementBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementBusinessProcess_RiskManagementId",
                table: "RiskManagementBusinessProcess",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementFindings_FindingId",
                table: "RiskManagementFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagementFindings_RiskManagementId",
                table: "RiskManagementFindings",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentAttachments_EmployeeId",
                table: "RiskTreatmentAttachments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentAttachments_RiskTreatmentId",
                table: "RiskTreatmentAttachments",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentContracts_ContractId",
                table: "RiskTreatmentContracts",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentContracts_RiskTreatmentId",
                table: "RiskTreatmentContracts",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentVendors_RiskTreatmentId",
                table: "RiskTreatmentVendors",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatmentVendors_VendorId",
                table: "RiskTreatmentVendors",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractRiskTreatments_RiskTreatments_RiskTreatmentId",
                table: "ContractRiskTreatments",
                column: "RiskTreatmentId",
                principalTable: "RiskTreatments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_MitigationStatusId",
                table: "RiskTreatments",
                column: "MitigationStatusId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_ResidualImpactRatingId",
                table: "RiskTreatments",
                column: "ResidualImpactRatingId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_ResidualLikelihoodRatingId",
                table: "RiskTreatments",
                column: "ResidualLikelihoodRatingId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_TreatmentActionId",
                table: "RiskTreatments",
                column: "TreatmentActionId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_Employees_MitigationOwnerId",
                table: "RiskTreatments",
                column: "MitigationOwnerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_Employees_OwnerId",
                table: "RiskTreatments",
                column: "OwnerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatments_RiskManagements_RiskManagementId",
                table: "RiskTreatments",
                column: "RiskManagementId",
                principalTable: "RiskManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContractRiskTreatments_RiskTreatments_RiskTreatmentId",
                table: "ContractRiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_MitigationStatusId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_ResidualImpactRatingId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_ResidualLikelihoodRatingId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_AbpDynamicPropertyValues_TreatmentActionId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_Employees_MitigationOwnerId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_Employees_OwnerId",
                table: "RiskTreatments");

            migrationBuilder.DropForeignKey(
                name: "FK_RiskTreatments_RiskManagements_RiskManagementId",
                table: "RiskTreatments");

            migrationBuilder.DropTable(
                name: "CitationControlStandards");

            migrationBuilder.DropTable(
                name: "CitationQuestions");

            migrationBuilder.DropTable(
                name: "ContactCyberAwarenessScores");

            migrationBuilder.DropTable(
                name: "ContractAttachments");

            migrationBuilder.DropTable(
                name: "ControlStandardCitations");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScoreEmployees");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScoreQuestions");

            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicatorAdministrators");

            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicatorBusinessUnits");

            migrationBuilder.DropTable(
                name: "KeyRiskIndicatorBusinessUnits");

            migrationBuilder.DropTable(
                name: "PolicyAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "PolicyDistributions");

            migrationBuilder.DropTable(
                name: "PolicyImpactedOranizations");

            migrationBuilder.DropTable(
                name: "PolicyReviewers");

            migrationBuilder.DropTable(
                name: "QuestionAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "RiskManagementAssetInformations");

            migrationBuilder.DropTable(
                name: "RiskManagementBusinessProcess");

            migrationBuilder.DropTable(
                name: "RiskManagementFindings");

            migrationBuilder.DropTable(
                name: "RiskTreatmentAttachments");

            migrationBuilder.DropTable(
                name: "RiskTreatmentContracts");

            migrationBuilder.DropTable(
                name: "RiskTreatmentVendors");

            migrationBuilder.DropTable(
                name: "ControlStandards");

            migrationBuilder.DropTable(
                name: "KeyPerformanceIndicators");

            migrationBuilder.DropTable(
                name: "KeyRiskIndicators");

            migrationBuilder.DropTable(
                name: "PolicyManagers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RiskTreatments",
                table: "RiskTreatments");

            migrationBuilder.RenameTable(
                name: "RiskTreatments",
                newName: "RiskTreatment");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_TreatmentActionId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_TreatmentActionId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_RiskManagementId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_RiskManagementId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_ResidualLikelihoodRatingId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_ResidualLikelihoodRatingId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_ResidualImpactRatingId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_ResidualImpactRatingId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_OwnerId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_OwnerId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_MitigationStatusId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_MitigationStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_RiskTreatments_MitigationOwnerId",
                table: "RiskTreatment",
                newName: "IX_RiskTreatment_MitigationOwnerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RiskTreatment",
                table: "RiskTreatment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContractRiskTreatments_RiskTreatment_RiskTreatmentId",
                table: "ContractRiskTreatments",
                column: "RiskTreatmentId",
                principalTable: "RiskTreatment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_MitigationStatusId",
                table: "RiskTreatment",
                column: "MitigationStatusId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualImpactRatingId",
                table: "RiskTreatment",
                column: "ResidualImpactRatingId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualLikelihoodRatingId",
                table: "RiskTreatment",
                column: "ResidualLikelihoodRatingId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_AbpDynamicPropertyValues_TreatmentActionId",
                table: "RiskTreatment",
                column: "TreatmentActionId",
                principalTable: "AbpDynamicPropertyValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_Employees_MitigationOwnerId",
                table: "RiskTreatment",
                column: "MitigationOwnerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_Employees_OwnerId",
                table: "RiskTreatment",
                column: "OwnerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RiskTreatment_RiskManagements_RiskManagementId",
                table: "RiskTreatment",
                column: "RiskManagementId",
                principalTable: "RiskManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
