using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_Hardware_Finding_VirtualAsset_Audit_AssetInformation_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationConfigurations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberValue = table.Column<int>(type: "int", nullable: true),
                    NumberDecimal = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    table.PrimaryKey("PK_ApplicationConfigurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AssetInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    AssetIdLV = table.Column<int>(type: "int", nullable: true),
                    AssetTypeId = table.Column<int>(type: "int", nullable: true),
                    AssetCategoryId = table.Column<int>(type: "int", nullable: true),
                    AssetLabelId = table.Column<int>(type: "int", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitGaurdianId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
                    OtherId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_AssetInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_AssetCategoryId",
                        column: x => x.AssetCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_AssetLabelId",
                        column: x => x.AssetLabelId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_AbpDynamicPropertyValues_OtherId",
                        column: x => x.OtherId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_BusinessUnits_BusinessUnitGaurdianId",
                        column: x => x.BusinessUnitGaurdianId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_BusinessUnits_BusinessUnitOwnerId",
                        column: x => x.BusinessUnitOwnerId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformations_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieDatacenters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    FacilityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityAddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityAddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitGaurdianId = table.Column<long>(type: "bigint", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_FacilitieDatacenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_FacilityTypeId",
                        column: x => x.FacilityTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_BusinessUnits_BusinessUnitGaurdianId",
                        column: x => x.BusinessUnitGaurdianId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_BusinessUnits_BusinessUnitOwnerId",
                        column: x => x.BusinessUnitOwnerId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenters_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Findings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    FindingId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindingTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindingDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    CategoryOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindingStatusId = table.Column<int>(type: "int", nullable: true),
                    RankingId = table.Column<int>(type: "int", nullable: true),
                    ClassificationId = table.Column<int>(type: "int", nullable: true),
                    FindingManagerId = table.Column<long>(type: "bigint", nullable: true),
                    FindingCoordinatorId = table.Column<long>(type: "bigint", nullable: true),
                    FindingOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    Criteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Consequence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionId = table.Column<int>(type: "int", nullable: true),
                    ReviewedId = table.Column<long>(type: "bigint", nullable: true),
                    ResponseId = table.Column<int>(type: "int", nullable: true),
                    PotentialCost = table.Column<int>(type: "int", nullable: true),
                    AssignedId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_Findings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_ActionId",
                        column: x => x.ActionId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_FindingStatusId",
                        column: x => x.FindingStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_RankingId",
                        column: x => x.RankingId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_AbpDynamicPropertyValues_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_Employees_AssignedId",
                        column: x => x.AssignedId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_Employees_FindingCoordinatorId",
                        column: x => x.FindingCoordinatorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_Employees_FindingManagerId",
                        column: x => x.FindingManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_Employees_FindingOwnerId",
                        column: x => x.FindingOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Findings_Employees_ReviewedId",
                        column: x => x.ReviewedId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    IncidentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnologyId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncidentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncidentCategoryId = table.Column<int>(type: "int", nullable: true),
                    IncidentTypesId = table.Column<int>(type: "int", nullable: true),
                    IncidentPriorityId = table.Column<int>(type: "int", nullable: true),
                    IncidentSeverityId = table.Column<int>(type: "int", nullable: true),
                    OccuredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdversaryId = table.Column<int>(type: "int", nullable: true),
                    ReportedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReporterFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReporterLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportedById = table.Column<long>(type: "bigint", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DetectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NotifierFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotifierLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    VoilationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RepeatIncident = table.Column<bool>(type: "bit", nullable: false),
                    EffectId = table.Column<int>(type: "int", nullable: true),
                    CriticalityId = table.Column<int>(type: "int", nullable: true),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eradication = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecoveryMeasures = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncidentImpactId = table.Column<int>(type: "int", nullable: true),
                    FollowUpAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IncidentClosedById = table.Column<long>(type: "bigint", nullable: true),
                    FollowUpCompletedById = table.Column<long>(type: "bigint", nullable: true),
                    IncidentStatusId = table.Column<int>(type: "int", nullable: true),
                    DetectedbyInternalControlsId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Incidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_AdversaryId",
                        column: x => x.AdversaryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_CriticalityId",
                        column: x => x.CriticalityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_DetectedbyInternalControlsId",
                        column: x => x.DetectedbyInternalControlsId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_EffectId",
                        column: x => x.EffectId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentCategoryId",
                        column: x => x.IncidentCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentImpactId",
                        column: x => x.IncidentImpactId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentPriorityId",
                        column: x => x.IncidentPriorityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentSeverityId",
                        column: x => x.IncidentSeverityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentStatusId",
                        column: x => x.IncidentStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_AbpDynamicPropertyValues_IncidentTypesId",
                        column: x => x.IncidentTypesId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_FollowUpCompletedById",
                        column: x => x.FollowUpCompletedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_IncidentClosedById",
                        column: x => x.IncidentClosedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Incidents_Employees_ReportedById",
                        column: x => x.ReportedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskManagements",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RiskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Criticality = table.Column<int>(type: "int", nullable: false),
                    LastEvaluationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskTriggerEvent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskTypeId = table.Column<int>(type: "int", nullable: true),
                    RiskCategoryId = table.Column<int>(type: "int", nullable: true),
                    RiskSourceId = table.Column<int>(type: "int", nullable: true),
                    RiskStateId = table.Column<int>(type: "int", nullable: true),
                    RiskStatusId = table.Column<int>(type: "int", nullable: true),
                    CompanyNameId = table.Column<long>(type: "bigint", nullable: true),
                    RiskOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    RiskManagerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    RiskScoringMethodId = table.Column<int>(type: "int", nullable: true),
                    NextEvaluation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NextEvaluationIRRBased = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RiskLikelihoodId = table.Column<int>(type: "int", nullable: true),
                    RiskImpactId = table.Column<int>(type: "int", nullable: true),
                    RiskLiRiskImpactkelihoodId = table.Column<int>(type: "int", nullable: true),
                    EvaluationFrequency = table.Column<int>(type: "int", nullable: true),
                    RiskScore = table.Column<int>(type: "int", nullable: true),
                    PersistenceId = table.Column<int>(type: "int", nullable: true),
                    VelocityId = table.Column<int>(type: "int", nullable: true),
                    ResidualRiskId = table.Column<int>(type: "int", nullable: true),
                    InherentRiskId = table.Column<int>(type: "int", nullable: true),
                    RiskTreatmentId = table.Column<int>(type: "int", nullable: true),
                    DurationId = table.Column<int>(type: "int", nullable: true),
                    ExpectedLoss = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_RiskManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_DurationId",
                        column: x => x.DurationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_InherentRiskId",
                        column: x => x.InherentRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_PersistenceId",
                        column: x => x.PersistenceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_ResidualRiskId",
                        column: x => x.ResidualRiskId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskCategoryId",
                        column: x => x.RiskCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskLikelihoodId",
                        column: x => x.RiskLikelihoodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskLiRiskImpactkelihoodId",
                        column: x => x.RiskLiRiskImpactkelihoodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskScoringMethodId",
                        column: x => x.RiskScoringMethodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskSourceId",
                        column: x => x.RiskSourceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskStateId",
                        column: x => x.RiskStateId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskStatusId",
                        column: x => x.RiskStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_RiskTypeId",
                        column: x => x.RiskTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_AbpDynamicPropertyValues_VelocityId",
                        column: x => x.VelocityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_Employees_RiskManagerId",
                        column: x => x.RiskManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_Employees_RiskOwnerId",
                        column: x => x.RiskOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskManagements_LockThreatOrganizations_CompanyNameId",
                        column: x => x.CompanyNameId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StrategicObjectives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    StrategicObjectiveId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExecutiveSponsorId = table.Column<long>(type: "bigint", nullable: true),
                    StrategicObjectiveTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_StrategicObjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_Employees_ExecutiveSponsorId",
                        column: x => x.ExecutiveSponsorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StrategicObjectives_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemApplications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    SystemId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SystemApplicationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitGaurdianId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_SystemApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemApplications_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_BusinessUnits_BusinessUnitGaurdianId",
                        column: x => x.BusinessUnitGaurdianId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_Employees_BusinessOwnerId",
                        column: x => x.BusinessOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplications_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContactFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    VendorTypeId = table.Column<int>(type: "int", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    VendorCriticalRatingId = table.Column<int>(type: "int", nullable: true),
                    VendorInitialRatingId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Vendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vendors_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendors_AbpDynamicPropertyValues_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendors_AbpDynamicPropertyValues_VendorCriticalRatingId",
                        column: x => x.VendorCriticalRatingId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendors_AbpDynamicPropertyValues_VendorInitialRatingId",
                        column: x => x.VendorInitialRatingId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vendors_AbpDynamicPropertyValues_VendorTypeId",
                        column: x => x.VendorTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetInformationBusinessprocess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetInformationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AssetInformationBusinessprocess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetInformationBusinessprocess_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformationBusinessprocess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetInformationBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetInformationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AssetInformationBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetInformationBusinessServices_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformationBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AssetInformationITservices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetInformationId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AssetInformationITservices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AssetInformationITservices_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AssetInformationITservices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieDatacenterBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilitieDatacenterId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FacilitieDatacenterBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterBusinessProcess_FacilitieDatacenters_FacilitieDatacenterId",
                        column: x => x.FacilitieDatacenterId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieDatacenterBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
                    FacilitieDatacenterId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FacilitieDatacenterBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterBusinessServices_FacilitieDatacenters_FacilitieDatacenterId",
                        column: x => x.FacilitieDatacenterId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FacilitieDatacenterITServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilitieDatacenterId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FacilitieDatacenterITServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterITServices_FacilitieDatacenters_FacilitieDatacenterId",
                        column: x => x.FacilitieDatacenterId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FacilitieDatacenterITServices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardwareAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AssetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HardwareAssetName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssetHardwareId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationsId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitGaurdianId = table.Column<long>(type: "bigint", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_HardwareAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_BusinessUnits_BusinessUnitGaurdianId",
                        column: x => x.BusinessUnitGaurdianId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_BusinessUnits_BusinessUnitOwnerId",
                        column: x => x.BusinessUnitOwnerId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_FacilitieDatacenters_LocationsId",
                        column: x => x.LocationsId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssets_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingAssetInformations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingAssetInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingAssetInformations_AssetInformations_AssetInformationId",
                        column: x => x.AssetInformationId,
                        principalTable: "AssetInformations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingAssetInformations_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingAuthoratativeSources",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    AuthoratativeDocumentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingAuthoratativeSources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingAuthoratativeSources_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingAuthoratativeSources_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingBusinessUnits_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingFacilitieDatacenters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    FacilitieDatacenterId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingFacilitieDatacenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingFacilitieDatacenters_FacilitieDatacenters_FacilitieDatacenterId",
                        column: x => x.FacilitieDatacenterId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingFacilitieDatacenters_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingOrganizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingOrganizations_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingOrganizations_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InternalControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    InternalControlId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrequencyTypeId = table.Column<int>(type: "int", nullable: true),
                    InternalAuditControlId = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    ControlFrequencyId = table.Column<int>(type: "int", nullable: true),
                    ControlStatusId = table.Column<int>(type: "int", nullable: true),
                    TestingProcedure = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcTypeId = table.Column<int>(type: "int", nullable: true),
                    ControlDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AutomationId = table.Column<int>(type: "int", nullable: true),
                    SampleSize = table.Column<int>(type: "int", nullable: true),
                    PriorityId = table.Column<int>(type: "int", nullable: true),
                    ComplianceStatusId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_InternalControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_AutomationId",
                        column: x => x.AutomationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_ComplianceStatusId",
                        column: x => x.ComplianceStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_ControlFrequencyId",
                        column: x => x.ControlFrequencyId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_ControlStatusId",
                        column: x => x.ControlStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_FrequencyTypeId",
                        column: x => x.FrequencyTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_IcTypeId",
                        column: x => x.IcTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_InternalAuditControlId",
                        column: x => x.InternalAuditControlId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_AbpDynamicPropertyValues_PriorityId",
                        column: x => x.PriorityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControls_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingIncidents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    IncidentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingIncidents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingIncidents_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingIncidents_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingRiskRegisters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingRiskRegisters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingRiskRegisters_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingRiskRegisters_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingStrategicObjectives",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingStrategicObjectives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingStrategicObjectives_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingStrategicObjectives_StrategicObjectives_StrategicObjectiveId",
                        column: x => x.StrategicObjectiveId,
                        principalTable: "StrategicObjectives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingSystemsApplications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingSystemsApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingSystemsApplications_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingSystemsApplications_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysteamApplicationBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemApplicationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_SysteamApplicationBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysteamApplicationBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysteamApplicationBusinessProcess_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SysteamApplicationITservices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_SysteamApplicationITservices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SysteamApplicationITservices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SysteamApplicationITservices_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SystemApplicationServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SystemApplicationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_SystemApplicationServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SystemApplicationServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SystemApplicationServices_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Audits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AuditId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditTypes = table.Column<int>(type: "int", nullable: false),
                    AuditTypeseother = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinacialYearId = table.Column<int>(type: "int", nullable: true),
                    FinacialYearOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuditDuration = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    AuditLocationAddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditLocationAddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    AuditAreaId = table.Column<int>(type: "int", nullable: true),
                    AuditReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeadAuditorId = table.Column<long>(type: "bigint", nullable: true),
                    AuditContactId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    BudgetedHours = table.Column<int>(type: "int", nullable: true),
                    ProjectNameId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    RelatedBsinessId = table.Column<long>(type: "bigint", nullable: true),
                    AuditScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditBackground = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditObjectives = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditMemo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentChecklist = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Audits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audits_AbpDynamicPropertyValues_AuditAreaId",
                        column: x => x.AuditAreaId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_AbpDynamicPropertyValues_FinacialYearId",
                        column: x => x.FinacialYearId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_BusinessUnits_RelatedBsinessId",
                        column: x => x.RelatedBsinessId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_Employees_AuditContactId",
                        column: x => x.AuditContactId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_Employees_LeadAuditorId",
                        column: x => x.LeadAuditorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_Projects_ProjectNameId",
                        column: x => x.ProjectNameId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Audits_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingVendors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingVendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingVendors_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VendorProductServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorServiceId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_VendorProductServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendorProductServices_AbpDynamicPropertyValues_VendorServiceId",
                        column: x => x.VendorServiceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendorProductServices_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingHardwareAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    HardwareAssetId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingHardwareAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingHardwareAssets_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingHardwareAssets_HardwareAssets_HardwareAssetId",
                        column: x => x.HardwareAssetId,
                        principalTable: "HardwareAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardwareAssetBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareAssetId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_HardwareAssetBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareAssetBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssetBusinessProcess_HardwareAssets_HardwareAssetId",
                        column: x => x.HardwareAssetId,
                        principalTable: "HardwareAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardwareAssetBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareAssetId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_HardwareAssetBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareAssetBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssetBusinessServices_HardwareAssets_HardwareAssetId",
                        column: x => x.HardwareAssetId,
                        principalTable: "HardwareAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HardwareAssetITservices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareAssetId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_HardwareAssetITservices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HardwareAssetITservices_HardwareAssets_HardwareAssetId",
                        column: x => x.HardwareAssetId,
                        principalTable: "HardwareAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HardwareAssetITservices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VirtualAssets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    VirtualAssetId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VirtualAssetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VirtualAssetUniqueIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VirtualMachine = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentVirtualHostId = table.Column<long>(type: "bigint", nullable: true),
                    HostedServerNameId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitGaurdianId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_VirtualAssets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_BusinessUnits_BusinessUnitGaurdianId",
                        column: x => x.BusinessUnitGaurdianId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_Employees_BusinessOwnerId",
                        column: x => x.BusinessOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_HardwareAssets_HostedServerNameId",
                        column: x => x.HostedServerNameId,
                        principalTable: "HardwareAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssets_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlDesigns",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ControlDesignId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResultStatusId = table.Column<int>(type: "int", nullable: true),
                    InternalControlId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    TestEffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_ControlDesigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlDesigns_AbpDynamicPropertyValues_ResultStatusId",
                        column: x => x.ResultStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlDesigns_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlDesigns_InternalControls_InternalControlId",
                        column: x => x.InternalControlId,
                        principalTable: "InternalControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingInternalControls",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InternalControlId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingInternalControls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingInternalControls_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingInternalControls_InternalControls_InternalControlId",
                        column: x => x.InternalControlId,
                        principalTable: "InternalControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditAttachments_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditAuditors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditAuditors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditAuditors_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditAuditors_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditBusinessProcess_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditBusinessServices_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditFacilitieDatacenters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
                    FacilitieDatacenterId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditFacilitieDatacenters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditFacilitieDatacenters_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditFacilitieDatacenters_FacilitieDatacenters_FacilitieDatacenterId",
                        column: x => x.FacilitieDatacenterId,
                        principalTable: "FacilitieDatacenters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditFindings_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditSystemApplications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditSystemApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditSystemApplications_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditSystemApplications_SystemApplications_SystemApplicationId",
                        column: x => x.SystemApplicationId,
                        principalTable: "SystemApplications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditTeams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditTeams_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditTeams_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditVendors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditVendors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditVendors_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditVendors_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ControlOperatingTests",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    COTId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestStatusId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestEffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SampleSize = table.Column<int>(type: "int", nullable: true),
                    InternalControlId = table.Column<long>(type: "bigint", nullable: true),
                    PerformedbyId = table.Column<long>(type: "bigint", nullable: true),
                    DataCollectionPurposeId = table.Column<int>(type: "int", nullable: true),
                    ActualResult = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TestNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollectionSampleSize = table.Column<int>(type: "int", nullable: true),
                    DataCollectionDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ControlOperatingTests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTests_AbpDynamicPropertyValues_DataCollectionPurposeId",
                        column: x => x.DataCollectionPurposeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTests_AbpDynamicPropertyValues_TestStatusId",
                        column: x => x.TestStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTests_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTests_Employees_PerformedbyId",
                        column: x => x.PerformedbyId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ControlOperatingTests_InternalControls_InternalControlId",
                        column: x => x.InternalControlId,
                        principalTable: "InternalControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingVirtualHosts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    VirtualAssetId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingVirtualHosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingVirtualHosts_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingVirtualHosts_VirtualAssets_VirtualAssetId",
                        column: x => x.VirtualAssetId,
                        principalTable: "VirtualAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingVirtualMachines",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    VirtualAssetId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingVirtualMachines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingVirtualMachines_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingVirtualMachines_VirtualAssets_VirtualAssetId",
                        column: x => x.VirtualAssetId,
                        principalTable: "VirtualAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VirtualAssetBusinessprocess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VirtualAssetId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_VirtualAssetBusinessprocess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VirtualAssetBusinessprocess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssetBusinessprocess_VirtualAssets_VirtualAssetId",
                        column: x => x.VirtualAssetId,
                        principalTable: "VirtualAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VirtualAssetBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VirtualAssetId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_VirtualAssetBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VirtualAssetBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssetBusinessServices_VirtualAssets_VirtualAssetId",
                        column: x => x.VirtualAssetId,
                        principalTable: "VirtualAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VirtualAssetITservices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VirtualAssetId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_VirtualAssetITservices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VirtualAssetITservices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VirtualAssetITservices_VirtualAssets_VirtualAssetId",
                        column: x => x.VirtualAssetId,
                        principalTable: "VirtualAssets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingControlDesigns",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    ControlDesignsId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingControlDesigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingControlDesigns_ControlDesigns_ControlDesignsId",
                        column: x => x.ControlDesignsId,
                        principalTable: "ControlDesigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingControlDesigns_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FindingControlOperatings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FindingId = table.Column<long>(type: "bigint", nullable: true),
                    ControlOperatingTestId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_FindingControlOperatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FindingControlOperatings_ControlOperatingTests_ControlOperatingTestId",
                        column: x => x.ControlOperatingTestId,
                        principalTable: "ControlOperatingTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FindingControlOperatings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationBusinessprocess_AssetInformationId",
                table: "AssetInformationBusinessprocess",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationBusinessprocess_BusinessProcessId",
                table: "AssetInformationBusinessprocess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationBusinessServices_AssetInformationId",
                table: "AssetInformationBusinessServices",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationBusinessServices_BusinessServiceId",
                table: "AssetInformationBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationITservices_AssetInformationId",
                table: "AssetInformationITservices",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformationITservices_ITServiceId",
                table: "AssetInformationITservices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_AssetCategoryId",
                table: "AssetInformations",
                column: "AssetCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_AssetLabelId",
                table: "AssetInformations",
                column: "AssetLabelId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_AssetTypeId",
                table: "AssetInformations",
                column: "AssetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_AvailibilityId",
                table: "AssetInformations",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_BusinessUnitGaurdianId",
                table: "AssetInformations",
                column: "BusinessUnitGaurdianId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_BusinessUnitOwnerId",
                table: "AssetInformations",
                column: "BusinessUnitOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_ConfidentialityId",
                table: "AssetInformations",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_CountryId",
                table: "AssetInformations",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_EmployeeId",
                table: "AssetInformations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_IntegrityId",
                table: "AssetInformations",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_LockThreatOrganizationId",
                table: "AssetInformations",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_AssetInformations_OtherId",
                table: "AssetInformations",
                column: "OtherId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditAttachments_AuditId",
                table: "AuditAttachments",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditAuditors_AuditId",
                table: "AuditAuditors",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditAuditors_EmployeeId",
                table: "AuditAuditors",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditBusinessProcess_AuditId",
                table: "AuditBusinessProcess",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditBusinessProcess_BusinessProcessId",
                table: "AuditBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditBusinessServices_AuditId",
                table: "AuditBusinessServices",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditBusinessServices_BusinessServiceId",
                table: "AuditBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditFacilitieDatacenters_AuditId",
                table: "AuditFacilitieDatacenters",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditFacilitieDatacenters_FacilitieDatacenterId",
                table: "AuditFacilitieDatacenters",
                column: "FacilitieDatacenterId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditFindings_AuditId",
                table: "AuditFindings",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditFindings_FindingId",
                table: "AuditFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_AuditAreaId",
                table: "Audits",
                column: "AuditAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_AuditContactId",
                table: "Audits",
                column: "AuditContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_CountryId",
                table: "Audits",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_FinacialYearId",
                table: "Audits",
                column: "FinacialYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_LeadAuditorId",
                table: "Audits",
                column: "LeadAuditorId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_LockThreatOrganizationId",
                table: "Audits",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_ProjectNameId",
                table: "Audits",
                column: "ProjectNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_RelatedBsinessId",
                table: "Audits",
                column: "RelatedBsinessId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_StatusId",
                table: "Audits",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Audits_VendorId",
                table: "Audits",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditSystemApplications_AuditId",
                table: "AuditSystemApplications",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditSystemApplications_SystemApplicationId",
                table: "AuditSystemApplications",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTeams_AuditId",
                table: "AuditTeams",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditTeams_EmployeeId",
                table: "AuditTeams",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditVendors_AuditId",
                table: "AuditVendors",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditVendors_VendorId",
                table: "AuditVendors",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlDesigns_EmployeeId",
                table: "ControlDesigns",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlDesigns_InternalControlId",
                table: "ControlDesigns",
                column: "InternalControlId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlDesigns_ResultStatusId",
                table: "ControlDesigns",
                column: "ResultStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTests_AuditId",
                table: "ControlOperatingTests",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTests_DataCollectionPurposeId",
                table: "ControlOperatingTests",
                column: "DataCollectionPurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTests_InternalControlId",
                table: "ControlOperatingTests",
                column: "InternalControlId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTests_PerformedbyId",
                table: "ControlOperatingTests",
                column: "PerformedbyId");

            migrationBuilder.CreateIndex(
                name: "IX_ControlOperatingTests_TestStatusId",
                table: "ControlOperatingTests",
                column: "TestStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterBusinessProcess_BusinessProcessId",
                table: "FacilitieDatacenterBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterBusinessProcess_FacilitieDatacenterId",
                table: "FacilitieDatacenterBusinessProcess",
                column: "FacilitieDatacenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterBusinessServices_BusinessServiceId",
                table: "FacilitieDatacenterBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterBusinessServices_FacilitieDatacenterId",
                table: "FacilitieDatacenterBusinessServices",
                column: "FacilitieDatacenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterITServices_FacilitieDatacenterId",
                table: "FacilitieDatacenterITServices",
                column: "FacilitieDatacenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenterITServices_ITServiceId",
                table: "FacilitieDatacenterITServices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_AvailibilityId",
                table: "FacilitieDatacenters",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_BusinessUnitGaurdianId",
                table: "FacilitieDatacenters",
                column: "BusinessUnitGaurdianId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_BusinessUnitOwnerId",
                table: "FacilitieDatacenters",
                column: "BusinessUnitOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_ConfidentialityId",
                table: "FacilitieDatacenters",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_CountryId",
                table: "FacilitieDatacenters",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_EmployeeId",
                table: "FacilitieDatacenters",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_FacilityTypeId",
                table: "FacilitieDatacenters",
                column: "FacilityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_IntegrityId",
                table: "FacilitieDatacenters",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_LockThreatOrganizationId",
                table: "FacilitieDatacenters",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilitieDatacenters_OthersId",
                table: "FacilitieDatacenters",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingAssetInformations_AssetInformationId",
                table: "FindingAssetInformations",
                column: "AssetInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingAssetInformations_FindingId",
                table: "FindingAssetInformations",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingAuthoratativeSources_AuthoratativeDocumentId",
                table: "FindingAuthoratativeSources",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingAuthoratativeSources_FindingId",
                table: "FindingAuthoratativeSources",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingBusinessUnits_BusinessUnitId",
                table: "FindingBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingBusinessUnits_FindingId",
                table: "FindingBusinessUnits",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingControlDesigns_ControlDesignsId",
                table: "FindingControlDesigns",
                column: "ControlDesignsId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingControlDesigns_FindingId",
                table: "FindingControlDesigns",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingControlOperatings_ControlOperatingTestId",
                table: "FindingControlOperatings",
                column: "ControlOperatingTestId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingControlOperatings_FindingId",
                table: "FindingControlOperatings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingFacilitieDatacenters_FacilitieDatacenterId",
                table: "FindingFacilitieDatacenters",
                column: "FacilitieDatacenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingFacilitieDatacenters_FindingId",
                table: "FindingFacilitieDatacenters",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingHardwareAssets_FindingId",
                table: "FindingHardwareAssets",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingHardwareAssets_HardwareAssetId",
                table: "FindingHardwareAssets",
                column: "HardwareAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingIncidents_FindingId",
                table: "FindingIncidents",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingIncidents_IncidentId",
                table: "FindingIncidents",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingInternalControls_FindingId",
                table: "FindingInternalControls",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingInternalControls_InternalControlId",
                table: "FindingInternalControls",
                column: "InternalControlId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingOrganizations_FindingId",
                table: "FindingOrganizations",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingOrganizations_LockThreatOrganizationId",
                table: "FindingOrganizations",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingRiskRegisters_FindingId",
                table: "FindingRiskRegisters",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingRiskRegisters_RiskManagementId",
                table: "FindingRiskRegisters",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_ActionId",
                table: "Findings",
                column: "ActionId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_AssignedId",
                table: "Findings",
                column: "AssignedId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_CategoryId",
                table: "Findings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_ClassificationId",
                table: "Findings",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_FindingCoordinatorId",
                table: "Findings",
                column: "FindingCoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_FindingManagerId",
                table: "Findings",
                column: "FindingManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_FindingOwnerId",
                table: "Findings",
                column: "FindingOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_FindingStatusId",
                table: "Findings",
                column: "FindingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_RankingId",
                table: "Findings",
                column: "RankingId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_ResponseId",
                table: "Findings",
                column: "ResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_ReviewedId",
                table: "Findings",
                column: "ReviewedId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingStrategicObjectives_FindingId",
                table: "FindingStrategicObjectives",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingStrategicObjectives_StrategicObjectiveId",
                table: "FindingStrategicObjectives",
                column: "StrategicObjectiveId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingSystemsApplications_FindingId",
                table: "FindingSystemsApplications",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingSystemsApplications_SystemApplicationId",
                table: "FindingSystemsApplications",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVendors_FindingId",
                table: "FindingVendors",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVendors_VendorId",
                table: "FindingVendors",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVirtualHosts_FindingId",
                table: "FindingVirtualHosts",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVirtualHosts_VirtualAssetId",
                table: "FindingVirtualHosts",
                column: "VirtualAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVirtualMachines_FindingId",
                table: "FindingVirtualMachines",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_FindingVirtualMachines_VirtualAssetId",
                table: "FindingVirtualMachines",
                column: "VirtualAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetBusinessProcess_BusinessProcessId",
                table: "HardwareAssetBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetBusinessProcess_HardwareAssetId",
                table: "HardwareAssetBusinessProcess",
                column: "HardwareAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetBusinessServices_BusinessServiceId",
                table: "HardwareAssetBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetBusinessServices_HardwareAssetId",
                table: "HardwareAssetBusinessServices",
                column: "HardwareAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetITservices_HardwareAssetId",
                table: "HardwareAssetITservices",
                column: "HardwareAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssetITservices_ITServiceId",
                table: "HardwareAssetITservices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_AvailibilityId",
                table: "HardwareAssets",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_BusinessUnitGaurdianId",
                table: "HardwareAssets",
                column: "BusinessUnitGaurdianId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_BusinessUnitOwnerId",
                table: "HardwareAssets",
                column: "BusinessUnitOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_ConfidentialityId",
                table: "HardwareAssets",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_EmployeeId",
                table: "HardwareAssets",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_IntegrityId",
                table: "HardwareAssets",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_LocationsId",
                table: "HardwareAssets",
                column: "LocationsId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_LockThreatOrganizationId",
                table: "HardwareAssets",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_HardwareAssets_OthersId",
                table: "HardwareAssets",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_AdversaryId",
                table: "Incidents",
                column: "AdversaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CriticalityId",
                table: "Incidents",
                column: "CriticalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_DetectedbyInternalControlsId",
                table: "Incidents",
                column: "DetectedbyInternalControlsId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_EffectId",
                table: "Incidents",
                column: "EffectId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_EmployeeId",
                table: "Incidents",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_FollowUpCompletedById",
                table: "Incidents",
                column: "FollowUpCompletedById");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentCategoryId",
                table: "Incidents",
                column: "IncidentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentClosedById",
                table: "Incidents",
                column: "IncidentClosedById");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentImpactId",
                table: "Incidents",
                column: "IncidentImpactId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentPriorityId",
                table: "Incidents",
                column: "IncidentPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentSeverityId",
                table: "Incidents",
                column: "IncidentSeverityId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentStatusId",
                table: "Incidents",
                column: "IncidentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_IncidentTypesId",
                table: "Incidents",
                column: "IncidentTypesId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ReportedById",
                table: "Incidents",
                column: "ReportedById");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_AutomationId",
                table: "InternalControls",
                column: "AutomationId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_ComplianceStatusId",
                table: "InternalControls",
                column: "ComplianceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_ControlFrequencyId",
                table: "InternalControls",
                column: "ControlFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_ControlStatusId",
                table: "InternalControls",
                column: "ControlStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_EmployeeId",
                table: "InternalControls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_FindingId",
                table: "InternalControls",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_FrequencyTypeId",
                table: "InternalControls",
                column: "FrequencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_IcTypeId",
                table: "InternalControls",
                column: "IcTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_InternalAuditControlId",
                table: "InternalControls",
                column: "InternalAuditControlId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_LockThreatOrganizationId",
                table: "InternalControls",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControls_PriorityId",
                table: "InternalControls",
                column: "PriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_BusinessUnitId",
                table: "RiskManagements",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_CompanyNameId",
                table: "RiskManagements",
                column: "CompanyNameId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_DurationId",
                table: "RiskManagements",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_InherentRiskId",
                table: "RiskManagements",
                column: "InherentRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_PersistenceId",
                table: "RiskManagements",
                column: "PersistenceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_ResidualRiskId",
                table: "RiskManagements",
                column: "ResidualRiskId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskCategoryId",
                table: "RiskManagements",
                column: "RiskCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskLikelihoodId",
                table: "RiskManagements",
                column: "RiskLikelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskLiRiskImpactkelihoodId",
                table: "RiskManagements",
                column: "RiskLiRiskImpactkelihoodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskManagerId",
                table: "RiskManagements",
                column: "RiskManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskOwnerId",
                table: "RiskManagements",
                column: "RiskOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskScoringMethodId",
                table: "RiskManagements",
                column: "RiskScoringMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskSourceId",
                table: "RiskManagements",
                column: "RiskSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskStateId",
                table: "RiskManagements",
                column: "RiskStateId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskStatusId",
                table: "RiskManagements",
                column: "RiskStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskTreatmentId",
                table: "RiskManagements",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_RiskTypeId",
                table: "RiskManagements",
                column: "RiskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskManagements_VelocityId",
                table: "RiskManagements",
                column: "VelocityId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_ExecutiveSponsorId",
                table: "StrategicObjectives",
                column: "ExecutiveSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_LockThreatOrganizationId",
                table: "StrategicObjectives",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_StatusId",
                table: "StrategicObjectives",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_StrategicObjectives_TypeId",
                table: "StrategicObjectives",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SysteamApplicationBusinessProcess_BusinessProcessId",
                table: "SysteamApplicationBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_SysteamApplicationBusinessProcess_SystemApplicationId",
                table: "SysteamApplicationBusinessProcess",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_SysteamApplicationITservices_ITServiceId",
                table: "SysteamApplicationITservices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SysteamApplicationITservices_SystemApplicationId",
                table: "SysteamApplicationITservices",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_AvailibilityId",
                table: "SystemApplications",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_BusinessOwnerId",
                table: "SystemApplications",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_BusinessUnitGaurdianId",
                table: "SystemApplications",
                column: "BusinessUnitGaurdianId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_BusinessUnitId",
                table: "SystemApplications",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_ConfidentialityId",
                table: "SystemApplications",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_CountryId",
                table: "SystemApplications",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_IntegrityId",
                table: "SystemApplications",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_LockThreatOrganizationId",
                table: "SystemApplications",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplications_OthersId",
                table: "SystemApplications",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplicationServices_BusinessServiceId",
                table: "SystemApplicationServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemApplicationServices_SystemApplicationId",
                table: "SystemApplicationServices",
                column: "SystemApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProductServices_VendorId",
                table: "VendorProductServices",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_VendorProductServices_VendorServiceId",
                table: "VendorProductServices",
                column: "VendorServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_CountryId",
                table: "Vendors",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_IndustryId",
                table: "Vendors",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorCriticalRatingId",
                table: "Vendors",
                column: "VendorCriticalRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorInitialRatingId",
                table: "Vendors",
                column: "VendorInitialRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendors_VendorTypeId",
                table: "Vendors",
                column: "VendorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetBusinessprocess_BusinessProcessId",
                table: "VirtualAssetBusinessprocess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetBusinessprocess_VirtualAssetId",
                table: "VirtualAssetBusinessprocess",
                column: "VirtualAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetBusinessServices_BusinessServiceId",
                table: "VirtualAssetBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetBusinessServices_VirtualAssetId",
                table: "VirtualAssetBusinessServices",
                column: "VirtualAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetITservices_ITServiceId",
                table: "VirtualAssetITservices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssetITservices_VirtualAssetId",
                table: "VirtualAssetITservices",
                column: "VirtualAssetId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_AvailibilityId",
                table: "VirtualAssets",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_BusinessOwnerId",
                table: "VirtualAssets",
                column: "BusinessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_BusinessUnitGaurdianId",
                table: "VirtualAssets",
                column: "BusinessUnitGaurdianId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_BusinessUnitId",
                table: "VirtualAssets",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_ConfidentialityId",
                table: "VirtualAssets",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_HostedServerNameId",
                table: "VirtualAssets",
                column: "HostedServerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_IntegrityId",
                table: "VirtualAssets",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_LockThreatOrganizationId",
                table: "VirtualAssets",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_VirtualAssets_OthersId",
                table: "VirtualAssets",
                column: "OthersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationConfigurations");

            migrationBuilder.DropTable(
                name: "AssetInformationBusinessprocess");

            migrationBuilder.DropTable(
                name: "AssetInformationBusinessServices");

            migrationBuilder.DropTable(
                name: "AssetInformationITservices");

            migrationBuilder.DropTable(
                name: "AuditAttachments");

            migrationBuilder.DropTable(
                name: "AuditAuditors");

            migrationBuilder.DropTable(
                name: "AuditBusinessProcess");

            migrationBuilder.DropTable(
                name: "AuditBusinessServices");

            migrationBuilder.DropTable(
                name: "AuditFacilitieDatacenters");

            migrationBuilder.DropTable(
                name: "AuditFindings");

            migrationBuilder.DropTable(
                name: "AuditSystemApplications");

            migrationBuilder.DropTable(
                name: "AuditTeams");

            migrationBuilder.DropTable(
                name: "AuditVendors");

            migrationBuilder.DropTable(
                name: "FacilitieDatacenterBusinessProcess");

            migrationBuilder.DropTable(
                name: "FacilitieDatacenterBusinessServices");

            migrationBuilder.DropTable(
                name: "FacilitieDatacenterITServices");

            migrationBuilder.DropTable(
                name: "FindingAssetInformations");

            migrationBuilder.DropTable(
                name: "FindingAuthoratativeSources");

            migrationBuilder.DropTable(
                name: "FindingBusinessUnits");

            migrationBuilder.DropTable(
                name: "FindingControlDesigns");

            migrationBuilder.DropTable(
                name: "FindingControlOperatings");

            migrationBuilder.DropTable(
                name: "FindingFacilitieDatacenters");

            migrationBuilder.DropTable(
                name: "FindingHardwareAssets");

            migrationBuilder.DropTable(
                name: "FindingIncidents");

            migrationBuilder.DropTable(
                name: "FindingInternalControls");

            migrationBuilder.DropTable(
                name: "FindingOrganizations");

            migrationBuilder.DropTable(
                name: "FindingRiskRegisters");

            migrationBuilder.DropTable(
                name: "FindingStrategicObjectives");

            migrationBuilder.DropTable(
                name: "FindingSystemsApplications");

            migrationBuilder.DropTable(
                name: "FindingVendors");

            migrationBuilder.DropTable(
                name: "FindingVirtualHosts");

            migrationBuilder.DropTable(
                name: "FindingVirtualMachines");

            migrationBuilder.DropTable(
                name: "HardwareAssetBusinessProcess");

            migrationBuilder.DropTable(
                name: "HardwareAssetBusinessServices");

            migrationBuilder.DropTable(
                name: "HardwareAssetITservices");

            migrationBuilder.DropTable(
                name: "SysteamApplicationBusinessProcess");

            migrationBuilder.DropTable(
                name: "SysteamApplicationITservices");

            migrationBuilder.DropTable(
                name: "SystemApplicationServices");

            migrationBuilder.DropTable(
                name: "VendorProductServices");

            migrationBuilder.DropTable(
                name: "VirtualAssetBusinessprocess");

            migrationBuilder.DropTable(
                name: "VirtualAssetBusinessServices");

            migrationBuilder.DropTable(
                name: "VirtualAssetITservices");

            migrationBuilder.DropTable(
                name: "AssetInformations");

            migrationBuilder.DropTable(
                name: "ControlDesigns");

            migrationBuilder.DropTable(
                name: "ControlOperatingTests");

            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "RiskManagements");

            migrationBuilder.DropTable(
                name: "StrategicObjectives");

            migrationBuilder.DropTable(
                name: "SystemApplications");

            migrationBuilder.DropTable(
                name: "VirtualAssets");

            migrationBuilder.DropTable(
                name: "Audits");

            migrationBuilder.DropTable(
                name: "InternalControls");

            migrationBuilder.DropTable(
                name: "HardwareAssets");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Findings");

            migrationBuilder.DropTable(
                name: "FacilitieDatacenters");
        }
    }
}
