using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_Question_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingIssueIdentifieds",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueManagementId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_MeetingIssueIdentifieds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingIssueIdentifieds_IssueManagements_IssueManagementId",
                        column: x => x.IssueManagementId,
                        principalTable: "IssueManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingIssueIdentifieds_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAudits",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProjectAudits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectAudits_Audits_AuditId",
                        column: x => x.AuditId,
                        principalTable: "Audits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectAudits_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionReviewAssessments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewAssessmentId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_QuestionReviewAssessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionReviewAssessments_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionReviewAssessments_ReviewAssessments_ReviewAssessmentId",
                        column: x => x.ReviewAssessmentId,
                        principalTable: "ReviewAssessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTargets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionTargetsId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_QuestionTargets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionTargets_AbpDynamicPropertyValues_QuestionTargetsId",
                        column: x => x.QuestionTargetsId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionTargets_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReviewDatas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ReviewId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewLeadId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewAssessmentId = table.Column<long>(type: "bigint", nullable: true),
                    CyberAwarenessScoreId = table.Column<long>(type: "bigint", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    AnswerPoints = table.Column<int>(type: "int", nullable: true),
                    ResponseTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BusinessUnitId = table.Column<long>(type: "bigint", nullable: true),
                    VendorId = table.Column<long>(type: "bigint", nullable: true),
                    ContactsId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionLibraryId = table.Column<long>(type: "bigint", nullable: true),
                    QuestionAssignedToId = table.Column<long>(type: "bigint", nullable: true),
                    SelectedAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RespondedById = table.Column<long>(type: "bigint", nullable: true),
                    VerifierId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewFeedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VerfiedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewQuestionStatusId = table.Column<int>(type: "int", nullable: true),
                    QuestionAnswered = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_ReviewDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_AbpDynamicPropertyValues_ReviewQuestionStatusId",
                        column: x => x.ReviewQuestionStatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_BusinessUnits_BusinessUnitId",
                        column: x => x.BusinessUnitId,
                        principalTable: "BusinessUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_CyberAwarenessScores_CyberAwarenessScoreId",
                        column: x => x.CyberAwarenessScoreId,
                        principalTable: "CyberAwarenessScores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Employees_QuestionAssignedToId",
                        column: x => x.QuestionAssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Employees_RespondedById",
                        column: x => x.RespondedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Employees_ReviewLeadId",
                        column: x => x.ReviewLeadId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Employees_VerifierId",
                        column: x => x.VerifierId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Questions_QuestionLibraryId",
                        column: x => x.QuestionLibraryId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_ReviewAssessments_ReviewAssessmentId",
                        column: x => x.ReviewAssessmentId,
                        principalTable: "ReviewAssessments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReviewDatas_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeReviewDatas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    ReviewDataId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_EmployeeReviewDatas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeReviewDatas_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EmployeeReviewDatas_ReviewDatas_ReviewDataId",
                        column: x => x.ReviewDataId,
                        principalTable: "ReviewDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionReviewData",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewDataId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_QuestionReviewData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionReviewData_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_QuestionReviewData_ReviewDatas_ReviewDataId",
                        column: x => x.ReviewDataId,
                        principalTable: "ReviewDatas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReviewDatas_EmployeeId",
                table: "EmployeeReviewDatas",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeReviewDatas_ReviewDataId",
                table: "EmployeeReviewDatas",
                column: "ReviewDataId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingIssueIdentifieds_IssueManagementId",
                table: "MeetingIssueIdentifieds",
                column: "IssueManagementId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingIssueIdentifieds_MeetingId",
                table: "MeetingIssueIdentifieds",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAudits_AuditId",
                table: "ProjectAudits",
                column: "AuditId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAudits_ProjectId",
                table: "ProjectAudits",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionReviewAssessments_QuestionId",
                table: "QuestionReviewAssessments",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionReviewAssessments_ReviewAssessmentId",
                table: "QuestionReviewAssessments",
                column: "ReviewAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionReviewData_QuestionId",
                table: "QuestionReviewData",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionReviewData_ReviewDataId",
                table: "QuestionReviewData",
                column: "ReviewDataId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTargets_QuestionId",
                table: "QuestionTargets",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTargets_QuestionTargetsId",
                table: "QuestionTargets",
                column: "QuestionTargetsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_BusinessUnitId",
                table: "ReviewDatas",
                column: "BusinessUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_ContactsId",
                table: "ReviewDatas",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_CyberAwarenessScoreId",
                table: "ReviewDatas",
                column: "CyberAwarenessScoreId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_LockThreatOrganizationId",
                table: "ReviewDatas",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_QuestionAssignedToId",
                table: "ReviewDatas",
                column: "QuestionAssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_QuestionId",
                table: "ReviewDatas",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_QuestionLibraryId",
                table: "ReviewDatas",
                column: "QuestionLibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_RespondedById",
                table: "ReviewDatas",
                column: "RespondedById");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_ReviewAssessmentId",
                table: "ReviewDatas",
                column: "ReviewAssessmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_ReviewLeadId",
                table: "ReviewDatas",
                column: "ReviewLeadId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_ReviewQuestionStatusId",
                table: "ReviewDatas",
                column: "ReviewQuestionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_VendorId",
                table: "ReviewDatas",
                column: "VendorId");

            migrationBuilder.CreateIndex(
                name: "IX_ReviewDatas_VerifierId",
                table: "ReviewDatas",
                column: "VerifierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeReviewDatas");

            migrationBuilder.DropTable(
                name: "MeetingIssueIdentifieds");

            migrationBuilder.DropTable(
                name: "ProjectAudits");

            migrationBuilder.DropTable(
                name: "QuestionReviewAssessments");

            migrationBuilder.DropTable(
                name: "QuestionReviewData");

            migrationBuilder.DropTable(
                name: "QuestionTargets");

            migrationBuilder.DropTable(
                name: "ReviewDatas");
        }
    }
}
