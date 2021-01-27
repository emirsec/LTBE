using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class addedBusinessServiceITServiceITServiceBusinessServiceITServiceBusinessUnitBusinessServiceUnitBusinessITServicetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    BusinessServiceId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BusinessUnitDependentId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitprimaryId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceManagerId = table.Column<long>(type: "bigint", nullable: true),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    IntergrityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_BusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessServices_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_AbpDynamicPropertyValues_IntergrityId",
                        column: x => x.IntergrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_AbpDynamicPropertyValues_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_BusinessUnits_BusinessUnitDependentId",
                        column: x => x.BusinessUnitDependentId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_BusinessUnits_BusinessUnitprimaryId",
                        column: x => x.BusinessUnitprimaryId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_Employees_BusinessServiceManagerId",
                        column: x => x.BusinessServiceManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_Employees_BusinessServiceOwnerId",
                        column: x => x.BusinessServiceOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServices_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ITServicesId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ITServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ServiceTypeId = table.Column<int>(type: "int", nullable: true),
                    ServiceClassificationId = table.Column<int>(type: "int", nullable: true),
                    AddressLineOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLineTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceOwnerId = table.Column<long>(type: "bigint", nullable: true),
                    ITServiceManagerId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    RegulatoryMandateId = table.Column<int>(type: "int", nullable: true),
                    ConfidentialityId = table.Column<int>(type: "int", nullable: true),
                    IntegrityId = table.Column<int>(type: "int", nullable: true),
                    OthersId = table.Column<int>(type: "int", nullable: true),
                    AvailibilityId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ITServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_AvailibilityId",
                        column: x => x.AvailibilityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_ConfidentialityId",
                        column: x => x.ConfidentialityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_IntegrityId",
                        column: x => x.IntegrityId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_OthersId",
                        column: x => x.OthersId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_RegulatoryMandateId",
                        column: x => x.RegulatoryMandateId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_ServiceClassificationId",
                        column: x => x.ServiceClassificationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_AbpDynamicPropertyValues_ServiceTypeId",
                        column: x => x.ServiceTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_Employees_ITServiceManagerId",
                        column: x => x.ITServiceManagerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_Employees_ITServiceOwnerId",
                        column: x => x.ITServiceOwnerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServices_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessServiceUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessServiceUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessServiceUnits_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessServiceUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessITServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_BusinessITServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessITServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BusinessITServices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceBusinessServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ITServiceBusinessServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServiceBusinessServices_BusinessServices_BusinessServiceId",
                        column: x => x.BusinessServiceId,
                        principalTable: "BusinessServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServiceBusinessServices_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ITServiceBusinessUnits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ITServiceId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ITServiceBusinessUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ITServiceBusinessUnits_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ITServiceBusinessUnits_ITServices_ITServiceId",
                        column: x => x.ITServiceId,
                        principalTable: "ITServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessITServices_BusinessServiceId",
                table: "BusinessITServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessITServices_ITServiceId",
                table: "BusinessITServices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_AvailibilityId",
                table: "BusinessServices",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_BusinessServiceManagerId",
                table: "BusinessServices",
                column: "BusinessServiceManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_BusinessServiceOwnerId",
                table: "BusinessServices",
                column: "BusinessServiceOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_BusinessUnitDependentId",
                table: "BusinessServices",
                column: "BusinessUnitDependentId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_BusinessUnitprimaryId",
                table: "BusinessServices",
                column: "BusinessUnitprimaryId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_ConfidentialityId",
                table: "BusinessServices",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_IntergrityId",
                table: "BusinessServices",
                column: "IntergrityId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_LockThreatOrganizationId",
                table: "BusinessServices",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_OthersId",
                table: "BusinessServices",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServices_ServiceTypeId",
                table: "BusinessServices",
                column: "ServiceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServiceUnits_BusinessServiceId",
                table: "BusinessServiceUnits",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessServiceUnits_BusinessUnitId",
                table: "BusinessServiceUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceBusinessServices_BusinessServiceId",
                table: "ITServiceBusinessServices",
                column: "BusinessServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceBusinessServices_ITServiceId",
                table: "ITServiceBusinessServices",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceBusinessUnits_BusinessUnitId",
                table: "ITServiceBusinessUnits",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServiceBusinessUnits_ITServiceId",
                table: "ITServiceBusinessUnits",
                column: "ITServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_AvailibilityId",
                table: "ITServices",
                column: "AvailibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_BusinessUnitId",
                table: "ITServices",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_ConfidentialityId",
                table: "ITServices",
                column: "ConfidentialityId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_CountryId",
                table: "ITServices",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_IntegrityId",
                table: "ITServices",
                column: "IntegrityId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_ITServiceManagerId",
                table: "ITServices",
                column: "ITServiceManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_ITServiceOwnerId",
                table: "ITServices",
                column: "ITServiceOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_LockThreatOrganizationId",
                table: "ITServices",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_OthersId",
                table: "ITServices",
                column: "OthersId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_RegulatoryMandateId",
                table: "ITServices",
                column: "RegulatoryMandateId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_ServiceClassificationId",
                table: "ITServices",
                column: "ServiceClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ITServices_ServiceTypeId",
                table: "ITServices",
                column: "ServiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessITServices");

            migrationBuilder.DropTable(
                name: "BusinessServiceUnits");

            migrationBuilder.DropTable(
                name: "ITServiceBusinessServices");

            migrationBuilder.DropTable(
                name: "ITServiceBusinessUnits");

            migrationBuilder.DropTable(
                name: "BusinessServices");

            migrationBuilder.DropTable(
                name: "ITServices");
        }
    }
}
