using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_State_action_Capa_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activitys",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityCurrentStep = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Activitys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CapaDetails",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAPAId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    CAPATitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalAuditorId = table.Column<long>(type: "bigint", nullable: true),
                    AuditId = table.Column<long>(type: "bigint", nullable: true),
                    AuditorExternalId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    BusinessProcessId = table.Column<long>(type: "bigint", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    FindingorNC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RootCause = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FollowUpAction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AuditeeId = table.Column<long>(type: "bigint", nullable: true),
                    FollowUpUpdates = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionPlanAccepted = table.Column<bool>(type: "bit", nullable: false),
                    DateAccepted = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_CapaDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CapaDetails_AbpDynamicPropertyValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_BusinessProcess_BusinessProcessId",
                        column: x => x.BusinessProcessId,
                        principalTable: "BusinessProcess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_Contacts_AuditorExternalId",
                        column: x => x.AuditorExternalId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_Employees_AuditeeId",
                        column: x => x.AuditeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_Employees_InternalAuditorId",
                        column: x => x.InternalAuditorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CapaDetails_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPageActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityActions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActionCategory = table.Column<int>(type: "int", nullable: false),
                    ActionTimeType = table.Column<int>(type: "int", nullable: false),
                    ActionTime = table.Column<int>(type: "int", nullable: true),
                    ActionTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionBCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionSMSId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ActivityActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Activitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionBCCRecipientsId",
                        column: x => x.ActionBCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionCCRecipientsId",
                        column: x => x.ActionCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionRecipientsId",
                        column: x => x.ActionRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityActions_Employees_ActionSMSId",
                        column: x => x.ActionSMSId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivitySteps",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
                    ActivityCriteria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityActors = table.Column<int>(type: "int", nullable: false),
                    IsActivityMand = table.Column<bool>(type: "bit", nullable: false),
                    ActivityType = table.Column<bool>(type: "bit", nullable: false),
                    ActivityDuration = table.Column<int>(type: "int", nullable: false),
                    ActivityDurationType = table.Column<int>(type: "int", nullable: false),
                    ActivityAutoCon = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ActivitySteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivitySteps_Activitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PageFields",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<long>(type: "bigint", nullable: true),
                    PageFieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageFieldDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageFieldType = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsPII = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsEnc = table.Column<bool>(type: "bit", nullable: false),
                    FieldIsVis = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_PageFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageFields_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageId = table.Column<long>(type: "bigint", nullable: true),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<bool>(type: "bit", nullable: false),
                    IsStateOpen = table.Column<bool>(type: "bit", nullable: false),
                    StateDeadline = table.Column<int>(type: "int", nullable: false),
                    StateDeadlineType = table.Column<int>(type: "int", nullable: false),
                    IsStateActive = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_States", x => x.Id);
                    table.ForeignKey(
                        name: "FK_States_Pages_PageId",
                        column: x => x.PageId,
                        principalTable: "Pages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StateActions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    ActionType = table.Column<int>(type: "int", nullable: false),
                    ActionCategory = table.Column<int>(type: "int", nullable: false),
                    ActionTime = table.Column<int>(type: "int", nullable: false),
                    ActionTimeType = table.Column<int>(type: "int", nullable: false),
                    ActionTemplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionBCCRecipientsId = table.Column<long>(type: "bigint", nullable: true),
                    ActionSMSId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_StateActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StateActions_Employees_ActionBCCRecipientsId",
                        column: x => x.ActionBCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateActions_Employees_ActionCCRecipientsId",
                        column: x => x.ActionCCRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateActions_Employees_ActionRecipientsId",
                        column: x => x.ActionRecipientsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateActions_Employees_ActionSMSId",
                        column: x => x.ActionSMSId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StateActions_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TemplateSubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemplateType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<long>(type: "bigint", nullable: true),
                    ActivityId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Templates_Activitys_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activitys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Templates_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionBCCRecipientsId",
                table: "ActivityActions",
                column: "ActionBCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionCCRecipientsId",
                table: "ActivityActions",
                column: "ActionCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionRecipientsId",
                table: "ActivityActions",
                column: "ActionRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActionSMSId",
                table: "ActivityActions",
                column: "ActionSMSId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityActions_ActivityId",
                table: "ActivityActions",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivitySteps_ActivityId",
                table: "ActivitySteps",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_AuditeeId",
                table: "CapaDetails",
                column: "AuditeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_AuditId",
                table: "CapaDetails",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_AuditorExternalId",
                table: "CapaDetails",
                column: "AuditorExternalId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_BusinessProcessId",
                table: "CapaDetails",
                column: "BusinessProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_InternalAuditorId",
                table: "CapaDetails",
                column: "InternalAuditorId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_LockThreatOrganizationId",
                table: "CapaDetails",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_CapaDetails_TypeId",
                table: "CapaDetails",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PageFields_PageId",
                table: "PageFields",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_StateActions_ActionBCCRecipientsId",
                table: "StateActions",
                column: "ActionBCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_StateActions_ActionCCRecipientsId",
                table: "StateActions",
                column: "ActionCCRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_StateActions_ActionRecipientsId",
                table: "StateActions",
                column: "ActionRecipientsId");

            migrationBuilder.CreateIndex(
                name: "IX_StateActions_ActionSMSId",
                table: "StateActions",
                column: "ActionSMSId");

            migrationBuilder.CreateIndex(
                name: "IX_StateActions_StateId",
                table: "StateActions",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_States_PageId",
                table: "States",
                column: "PageId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_ActivityId",
                table: "Templates",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_StateId",
                table: "Templates",
                column: "StateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityActions");

            migrationBuilder.DropTable(
                name: "ActivitySteps");

            migrationBuilder.DropTable(
                name: "CapaDetails");

            migrationBuilder.DropTable(
                name: "PageFields");

            migrationBuilder.DropTable(
                name: "StateActions");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Activitys");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Pages");
        }
    }
}
