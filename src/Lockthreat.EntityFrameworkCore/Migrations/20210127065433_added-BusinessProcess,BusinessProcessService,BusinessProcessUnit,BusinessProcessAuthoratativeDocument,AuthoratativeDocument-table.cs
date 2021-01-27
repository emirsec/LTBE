using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class addedBusinessProcessBusinessProcessServiceBusinessProcessUnitBusinessProcessAuthoratativeDocumentAuthoratativeDocumenttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    AuthorityDocumentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorityDocumentOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthoratativeDocumentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MandateTypeId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthoratativeDocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImportantNotice = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_AuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocuments_AbpDynamicPropertyValues_MandateTypeId",
                        column: x => x.MandateTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AuthoratativeDocuments_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcess",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    BusinessProcessId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessTypeId = table.Column<int>(type: "int", nullable: true),
                    SlaApplicableId = table.Column<int>(type: "int", nullable: true),
                    ActivityCycleId = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessManagerId = table.Column<long>(type: "bigint", nullable: true),
                    ProcessOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    RegulatoryId = table.Column<int>(type: "int", nullable: true),
                    ProcessPriorityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    ReviewPeriodId = table.Column<int>(type: "int", nullable: true),
                    IntergrityId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_BusinessProcess", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_ActivityCycleId",
                        column: x => x.ActivityCycleId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_IntergrityId",
                        column: x => x.IntergrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_ProcessPriorityId",
                        column: x => x.ProcessPriorityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_ProcessTypeId",
                        column: x => x.ProcessTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_RegulatoryId",
                        column: x => x.RegulatoryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_ReviewPeriodId",
                        column: x => x.ReviewPeriodId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_SlaApplicableId",
                        column: x => x.SlaApplicableId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_Employees_ProcessManagerId",
                        column: x => x.ProcessManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_Employees_ProcessOwnerId",
                        column: x => x.ProcessOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcess_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcessAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessProcessAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcessAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcessAuthoratativeDocuments_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessProcessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcessServices_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessProcessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessProcessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessProcessUnits_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessProcessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocuments_MandateTypeId",
                table: "AuthoratativeDocuments",
                column: "MandateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthoratativeDocuments_TypeId",
                table: "AuthoratativeDocuments",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ActivityCycleId",
                table: "BusinessProcess",
                column: "ActivityCycleId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_AvailibilityId",
                table: "BusinessProcess",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_BusinessUnitId",
                table: "BusinessProcess",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ConfidentialityId",
                table: "BusinessProcess",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_CountryId",
                table: "BusinessProcess",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_IntergrityId",
                table: "BusinessProcess",
                column: "IntergrityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_LockThreatOrganizationId",
                table: "BusinessProcess",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_OthersId",
                table: "BusinessProcess",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ProcessManagerId",
                table: "BusinessProcess",
                column: "ProcessManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ProcessOwnerId",
                table: "BusinessProcess",
                column: "ProcessOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ProcessPriorityId",
                table: "BusinessProcess",
                column: "ProcessPriorityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ProcessTypeId",
                table: "BusinessProcess",
                column: "ProcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_RegulatoryId",
                table: "BusinessProcess",
                column: "RegulatoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_ReviewPeriodId",
                table: "BusinessProcess",
                column: "ReviewPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_SlaApplicableId",
                table: "BusinessProcess",
                column: "SlaApplicableId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcess_StatusId",
                table: "BusinessProcess",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "BusinessProcessAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessAuthoratativeDocuments_BusinessProcessId",
                table: "BusinessProcessAuthoratativeDocuments",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessServices_BusinessProcessId",
                table: "BusinessProcessServices",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessServices_BusinessServiceId",
                table: "BusinessProcessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessUnits_BusinessProcessId",
                table: "BusinessProcessUnits",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessProcessUnits_BusinessUnitId",
                table: "BusinessProcessUnits",
                column: "BusinessUnitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessProcessAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "BusinessProcessServices");

            migrationBuilder.DropTable(
                name: "BusinessProcessUnits");

            migrationBuilder.DropTable(
                name: "AuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "BusinessProcess");
        }
    }
}
