using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_CyberAwareness_Incident_Contact_Citation_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuditWorkpaperEvidences",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentSourceId = table.Column<int>(type: "int", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditWorkpaperEvidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditWorkpaperEvidences_AbpDynamicPropertyValues_DocumentSourceId",
                        column: x => x.DocumentSourceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditWorkpaperEvidences_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditWorkpaperEvidences_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditWorkpapers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkpaperId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkpaperTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreparedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuditId = table.Column<int>(type: "int", nullable: true),
                    AuditId1 = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkpaperAttachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkpaperLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuditWorkpapers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditWorkpapers_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditWorkpapers_Audits_AuditId1",
                        column: x => x.AuditId1,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditWorkpapers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthoratativeDocumentBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthoratativeDocumentsId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuthoratativeDocumentBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocumentBusinessUnits_AuthoratativeDocuments_AuthoratativeDocumentsId",
                        column: x => x.AuthoratativeDocumentsId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocumentBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthoratativeDocumentOrganization",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuthoratativeDocumentOrganization", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocumentOrganization_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocumentOrganization_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AuthoratativeDocumentId = table.Column<long>(type: "bigint", nullable: true),
                    ParentCitationId = table.Column<int>(type: "int", nullable: true),
                    CitationTypeId = table.Column<int>(type: "int", nullable: true),
                    CitationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControlRequirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationOriginId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FrameworkObjectivesId = table.Column<int>(type: "int", nullable: true),
                    CitationTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationClassId = table.Column<int>(type: "int", nullable: true),
                    CustomApplicability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UCFCId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CITLV = table.Column<int>(type: "int", nullable: true),
                    ControlObjective = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RelatedContentImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Citations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_CitationClassId",
                        column: x => x.CitationClassId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_CitationTypeId",
                        column: x => x.CitationTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AbpDynamicPropertyValues_FrameworkObjectivesId",
                        column: x => x.FrameworkObjectivesId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Citations_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ContactId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactTypeId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    jobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LoginUserId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacts_AbpDynamicPropertyValues_ContactTypeId",
                        column: x => x.ContactTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Employees_LoginUserId",
                        column: x => x.LoginUserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contacts_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ContractId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContractReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContractValue = table.Column<int>(type: "int", nullable: true),
                    ContractTypeId = table.Column<int>(type: "int", nullable: true),
                    ContractCategoryId = table.Column<int>(type: "int", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contracts_AbpDynamicPropertyValues_ContractCategoryId",
                        column: x => x.ContractCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_AbpDynamicPropertyValues_ContractTypeId",
                        column: x => x.ContractTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contracts_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CASId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CASName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    TargetTypeId = table.Column<int>(type: "int", nullable: true),
                    SatusId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    SourceId = table.Column<int>(type: "int", nullable: true),
                    ScheduleId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsQuestionarieGenerated = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_CyberAwarenessScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScores_AbpDynamicPropertyValues_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScores_AbpDynamicPropertyValues_SourceId",
                        column: x => x.SourceId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScores_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScores_AbpDynamicPropertyValues_TargetTypeId",
                        column: x => x.TargetTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScores_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_EmployeeAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeAttachments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBusinessServices",
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
                    table.PrimaryKey("PK_EmployeeBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeBusinessServices_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IncidentAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentAttachments_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentFindings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IncidentFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentFindings_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IncidentReviewers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IncidentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_IncidentReviewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncidentReviewers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IncidentReviewers_Incidents_IncidentId",
                        column: x => x.IncidentId,
                        principalTable: "Incidents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InternalControlFindings",
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
                    table.PrimaryKey("PK_InternalControlFindings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InternalControlFindings_Findings_FindingId",
                        column: x => x.FindingId,
                        principalTable: "Findings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InternalControlFindings_InternalControls_InternalControlId",
                        column: x => x.InternalControlId,
                        principalTable: "InternalControls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ITServiceAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServiceAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServiceAuthoratativeDocuments_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    QuestionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionnaireTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SourceQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionId = table.Column<int>(type: "int", nullable: true),
                    QuestionAreaId = table.Column<int>(type: "int", nullable: true),
                    QuestionCategoryId = table.Column<int>(type: "int", nullable: true),
                    QuestionStatusId = table.Column<int>(type: "int", nullable: true),
                    AnswerTypeId = table.Column<int>(type: "int", nullable: true),
                    AnswerTypes = table.Column<bool>(type: "bit", nullable: false),
                    AnswerValues = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnswerPoints = table.Column<int>(type: "int", nullable: true),
                    TotalPoints = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_AbpDynamicPropertyValues_AnswerTypeId",
                        column: x => x.AnswerTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_AbpDynamicPropertyValues_QuestionAreaId",
                        column: x => x.QuestionAreaId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_AbpDynamicPropertyValues_QuestionCategoryId",
                        column: x => x.QuestionCategoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_AbpDynamicPropertyValues_QuestionStatusId",
                        column: x => x.QuestionStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_AbpDynamicPropertyValues_SectionId",
                        column: x => x.SectionId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RiskTreatment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    RiskTreatmentPlanId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskTreatmentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskManagementId = table.Column<long>(type: "bigint", nullable: true),
                    OwnerId = table.Column<long>(type: "bigint", nullable: true),
                    TreatmentActionId = table.Column<int>(type: "int", nullable: true),
                    MitigationOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MitigationCost = table.Column<int>(type: "int", nullable: true),
                    MitigationActivity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MitigationStatusId = table.Column<int>(type: "int", nullable: true),
                    RiskAvoidancePlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResidualImpactRatingId = table.Column<int>(type: "int", nullable: true),
                    ResidualLikelihoodRatingId = table.Column<int>(type: "int", nullable: true),
                    ResidualRiskNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_RiskTreatment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_AbpDynamicPropertyValues_MitigationStatusId",
                        column: x => x.MitigationStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualImpactRatingId",
                        column: x => x.ResidualImpactRatingId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_AbpDynamicPropertyValues_ResidualLikelihoodRatingId",
                        column: x => x.ResidualLikelihoodRatingId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_AbpDynamicPropertyValues_TreatmentActionId",
                        column: x => x.TreatmentActionId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_Employees_MitigationOwnerId",
                        column: x => x.MitigationOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_Employees_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RiskTreatment_RiskManagements_RiskManagementId",
                        column: x => x.RiskManagementId,
                        principalTable: "RiskManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuditWorkpaperReviewers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    AuditWorkpaperId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AuditWorkpaperReviewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuditWorkpaperReviewers_AuditWorkpapers_AuditWorkpaperId",
                        column: x => x.AuditWorkpaperId,
                        principalTable: "AuditWorkpapers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuditWorkpaperReviewers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractBusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractBusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractBusinessProcess_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractBusinessProcess_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractBusinessServices_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractEmployeeNotifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractEmployeeNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractEmployeeNotifications_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractEmployeeNotifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractEmployees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractEmployees_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractEmployees_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractITServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractITServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractITServices_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractITServices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceContracts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ITServiceContracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServiceContracts_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServiceContracts_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScoreAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CyberAwarenessScoreAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreAuthoratativeDocuments_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScoreBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CyberAwarenessScoreBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreBusinessUnits_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CyberAwarenessScoreOrganizations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_CyberAwarenessScoreOrganizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreOrganizations_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CyberAwarenessScoreOrganizations_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractRiskTreatments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractsId = table.Column<long>(type: "bigint", nullable: true),
                    ContractId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ContractRiskTreatments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractRiskTreatments_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractRiskTreatments_RiskTreatment_RiskTreatmentId",
                        column: x => x.RiskTreatmentId,
                        principalTable: "RiskTreatment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpaperEvidences_AuditId",
                table: "AuditWorkpaperEvidences",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpaperEvidences_DocumentSourceId",
                table: "AuditWorkpaperEvidences",
                column: "DocumentSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpaperEvidences_EmployeeId",
                table: "AuditWorkpaperEvidences",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpaperReviewers_AuditWorkpaperId",
                table: "AuditWorkpaperReviewers",
                column: "AuditWorkpaperId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpaperReviewers_EmployeeId",
                table: "AuditWorkpaperReviewers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpapers_AuditId1",
                table: "AuditWorkpapers",
                column: "AuditId1");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpapers_EmployeeId",
                table: "AuditWorkpapers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuditWorkpapers_TypeId",
                table: "AuditWorkpapers",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocumentBusinessUnits_AuthoratativeDocumentsId",
                table: "AuthoratativeDocumentBusinessUnits",
                column: "AuthoratativeDocumentsId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocumentBusinessUnits_BusinessUnitId",
                table: "AuthoratativeDocumentBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocumentOrganization_AuthoratativeDocumentId",
                table: "AuthoratativeDocumentOrganization",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocumentOrganization_LockThreatOrganizationId",
                table: "AuthoratativeDocumentOrganization",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_AuthoratativeDocumentId",
                table: "Citations",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_CitationClassId",
                table: "Citations",
                column: "CitationClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_CitationTypeId",
                table: "Citations",
                column: "CitationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Citations_FrameworkObjectivesId",
                table: "Citations",
                column: "FrameworkObjectivesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_ContactTypeId",
                table: "Contacts",
                column: "ContactTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_CountryId",
                table: "Contacts",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LockThreatOrganizationId",
                table: "Contacts",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_LoginUserId",
                table: "Contacts",
                column: "LoginUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_VendorId",
                table: "Contacts",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractBusinessProcess_BusinessProcessId",
                table: "ContractBusinessProcess",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractBusinessProcess_ContractId",
                table: "ContractBusinessProcess",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractBusinessServices_BusinessServiceId",
                table: "ContractBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractBusinessServices_ContractId",
                table: "ContractBusinessServices",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployeeNotifications_ContractId",
                table: "ContractEmployeeNotifications",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployeeNotifications_EmployeeId",
                table: "ContractEmployeeNotifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployees_ContractId",
                table: "ContractEmployees",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractEmployees_EmployeeId",
                table: "ContractEmployees",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractITServices_ContractId",
                table: "ContractITServices",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractITServices_ITServiceId",
                table: "ContractITServices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractRiskTreatments_ContractId",
                table: "ContractRiskTreatments",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractRiskTreatments_RiskTreatmentId",
                table: "ContractRiskTreatments",
                column: "RiskTreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractCategoryId",
                table: "Contracts",
                column: "ContractCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ContractTypeId",
                table: "Contracts",
                column: "ContractTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_EmployeeId",
                table: "Contracts",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_LockThreatOrganizationId",
                table: "Contracts",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_VendorId",
                table: "Contracts",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "CyberAwarenessScoreAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreAuthoratativeDocuments_CyberAwarenessScoreId",
                table: "CyberAwarenessScoreAuthoratativeDocuments",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreBusinessUnits_BusinessUnitId",
                table: "CyberAwarenessScoreBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreBusinessUnits_CyberAwarenessScoreId",
                table: "CyberAwarenessScoreBusinessUnits",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreOrganizations_CyberAwarenessScoreId",
                table: "CyberAwarenessScoreOrganizations",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScoreOrganizations_LockThreatOrganizationId",
                table: "CyberAwarenessScoreOrganizations",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScores_EmployeeId",
                table: "CyberAwarenessScores",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScores_ScheduleId",
                table: "CyberAwarenessScores",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScores_SourceId",
                table: "CyberAwarenessScores",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScores_StatusId",
                table: "CyberAwarenessScores",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CyberAwarenessScores_TargetTypeId",
                table: "CyberAwarenessScores",
                column: "TargetTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeAttachments_EmployeeId",
                table: "EmployeeAttachments",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBusinessServices_BusinessServiceId",
                table: "EmployeeBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBusinessServices_EmployeeId",
                table: "EmployeeBusinessServices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentAttachments_IncidentId",
                table: "IncidentAttachments",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentFindings_FindingId",
                table: "IncidentFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentFindings_IncidentId",
                table: "IncidentFindings",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentReviewers_EmployeeId",
                table: "IncidentReviewers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncidentReviewers_IncidentId",
                table: "IncidentReviewers",
                column: "IncidentId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControlFindings_FindingId",
                table: "InternalControlFindings",
                column: "FindingId");

            migrationBuilder.CreateIndex(
                name: "IX_InternalControlFindings_InternalControlId",
                table: "InternalControlFindings",
                column: "InternalControlId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "ITServiceAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceAuthoratativeDocuments_ITServiceId",
                table: "ITServiceAuthoratativeDocuments",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceContracts_ContractId",
                table: "ITServiceContracts",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceContracts_ITServiceId",
                table: "ITServiceContracts",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_AnswerTypeId",
                table: "Questions",
                column: "AnswerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionAreaId",
                table: "Questions",
                column: "QuestionAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionCategoryId",
                table: "Questions",
                column: "QuestionCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionStatusId",
                table: "Questions",
                column: "QuestionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SectionId",
                table: "Questions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_MitigationOwnerId",
                table: "RiskTreatment",
                column: "MitigationOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_MitigationStatusId",
                table: "RiskTreatment",
                column: "MitigationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_OwnerId",
                table: "RiskTreatment",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_ResidualImpactRatingId",
                table: "RiskTreatment",
                column: "ResidualImpactRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_ResidualLikelihoodRatingId",
                table: "RiskTreatment",
                column: "ResidualLikelihoodRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_RiskManagementId",
                table: "RiskTreatment",
                column: "RiskManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_RiskTreatment_TreatmentActionId",
                table: "RiskTreatment",
                column: "TreatmentActionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditWorkpaperEvidences");

            migrationBuilder.DropTable(
                name: "AuditWorkpaperReviewers");

            migrationBuilder.DropTable(
                name: "AuthoratativeDocumentBusinessUnits");

            migrationBuilder.DropTable(
                name: "AuthoratativeDocumentOrganization");

            migrationBuilder.DropTable(
                name: "Citations");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ContractBusinessProcess");

            migrationBuilder.DropTable(
                name: "ContractBusinessServices");

            migrationBuilder.DropTable(
                name: "ContractEmployeeNotifications");

            migrationBuilder.DropTable(
                name: "ContractEmployees");

            migrationBuilder.DropTable(
                name: "ContractITServices");

            migrationBuilder.DropTable(
                name: "ContractRiskTreatments");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScoreAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScoreBusinessUnits");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScoreOrganizations");

            migrationBuilder.DropTable(
                name: "EmployeeAttachments");

            migrationBuilder.DropTable(
                name: "EmployeeBusinessServices");

            migrationBuilder.DropTable(
                name: "IncidentAttachments");

            migrationBuilder.DropTable(
                name: "IncidentFindings");

            migrationBuilder.DropTable(
                name: "IncidentReviewers");

            migrationBuilder.DropTable(
                name: "InternalControlFindings");

            migrationBuilder.DropTable(
                name: "ITServiceAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "ITServiceContracts");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AuditWorkpapers");

            migrationBuilder.DropTable(
                name: "RiskTreatment");

            migrationBuilder.DropTable(
                name: "CyberAwarenessScores");

            migrationBuilder.DropTable(
                name: "Contracts");
        }
    }
}
