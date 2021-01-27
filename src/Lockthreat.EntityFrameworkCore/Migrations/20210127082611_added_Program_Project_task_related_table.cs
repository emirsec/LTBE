using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lockthreat.Migrations
{
    public partial class added_Program_Project_task_related_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddTasks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    TaskId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Frequencys = table.Column<int>(type: "int", nullable: false),
                    Prioritys = table.Column<int>(type: "int", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Days = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualCompleted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TaskTypeId = table.Column<int>(type: "int", nullable: true),
                    LinkedToId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    RiskLevelId = table.Column<int>(type: "int", nullable: true),
                    RequestedById = table.Column<long>(type: "bigint", nullable: true),
                    AssignedUserId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_AddTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddTasks_AbpDynamicPropertyValues_LinkedToId",
                        column: x => x.LinkedToId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_AbpDynamicPropertyValues_RiskLevelId",
                        column: x => x.RiskLevelId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_AbpDynamicPropertyValues_StatusId",
                        column: x => x.StatusId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_AbpDynamicPropertyValues_TaskTypeId",
                        column: x => x.TaskTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_Employees_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_Employees_AssignedUserId",
                        column: x => x.AssignedUserId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddTasks_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GrcPrograms",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ProgramId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramTeamEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProgramLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    ProgramSponsorId = table.Column<long>(type: "bigint", nullable: true),
                    ProgramDirectorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_GrcPrograms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GrcPrograms_Employees_ProgramDirectorId",
                        column: x => x.ProgramDirectorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GrcPrograms_Employees_ProgramSponsorId",
                        column: x => x.ProgramSponsorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GrcPrograms_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    MeetingId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MeetingEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MeetingvenueId = table.Column<long>(type: "bigint", nullable: true),
                    MeetingLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    MeetingAgenda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    MinutesofMeeting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MinutesofMeetingAttachedment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeetingConclusion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizerId = table.Column<long>(type: "bigint", nullable: true),
                    MeetingTypeId = table.Column<int>(type: "int", nullable: true),
                    MeetingClassificationId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Meetings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meetings_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_AbpDynamicPropertyValues_MeetingClassificationId",
                        column: x => x.MeetingClassificationId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_AbpDynamicPropertyValues_MeetingTypeId",
                        column: x => x.MeetingTypeId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Meetings_Employees_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddTaskId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_TaskAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAttachments_AddTasks_AddTaskId",
                        column: x => x.AddTaskId,
                        principalTable: "AddTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskNotifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddTaskId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_TaskNotifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskNotifications_AddTasks_AddTaskId",
                        column: x => x.AddTaskId,
                        principalTable: "AddTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskNotifications_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskRelatedMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddTaskId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_TaskRelatedMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskRelatedMembers_AddTasks_AddTaskId",
                        column: x => x.AddTaskId,
                        principalTable: "AddTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskRelatedMembers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramAuthoritativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrcProgramId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProgramAuthoritativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramAuthoritativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramAuthoritativeDocuments_GrcPrograms_GrcProgramId",
                        column: x => x.GrcProgramId,
                        principalTable: "GrcPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramCoordinators",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrcProgramId = table.Column<long>(type: "bigint", nullable: true),
                    ProgramCoordinatorsId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProgramCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramCoordinators_Employees_ProgramCoordinatorsId",
                        column: x => x.ProgramCoordinatorsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramCoordinators_GrcPrograms_GrcProgramId",
                        column: x => x.GrcProgramId,
                        principalTable: "GrcPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramCountrys",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrcProgramId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ProgramCountrys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramCountrys_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramCountrys_GrcPrograms_GrcProgramId",
                        column: x => x.GrcProgramId,
                        principalTable: "GrcPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProgramTeams",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GrcProgramId = table.Column<long>(type: "bigint", nullable: true),
                    ProgramTeamsId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProgramTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgramTeams_Employees_ProgramTeamsId",
                        column: x => x.ProgramTeamsId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProgramTeams_GrcPrograms_GrcProgramId",
                        column: x => x.GrcProgramId,
                        principalTable: "GrcPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenantId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndustryId = table.Column<int>(type: "int", nullable: true),
                    ProjectLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockThreatOrganizationId = table.Column<long>(type: "bigint", nullable: true),
                    ParentProgramId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectScope = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectSponsorId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectDirectorId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_AbpDynamicPropertyValues_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Employees_ProjectDirectorId",
                        column: x => x.ProjectDirectorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Employees_ProjectSponsorId",
                        column: x => x.ProjectSponsorId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_GrcPrograms_ParentProgramId",
                        column: x => x.ParentProgramId,
                        principalTable: "GrcPrograms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_LockThreatOrganizations_LockThreatOrganizationId",
                        column: x => x.LockThreatOrganizationId,
                        principalTable: "LockThreatOrganizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetingAbsenteeUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_MeetingAbsenteeUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingAbsenteeUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingAbsenteeUsers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetingAttendUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_MeetingAttendUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingAttendUsers_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingAttendUsers_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeetingTasks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddTaskId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_MeetingTasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MeetingTasks_AddTasks_AddTaskId",
                        column: x => x.AddTaskId,
                        principalTable: "AddTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MeetingTasks_Meetings_MeetingId",
                        column: x => x.MeetingId,
                        principalTable: "Meetings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAuthoratativeDocuments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProjectAuthoratativeDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectAuthoratativeDocuments_AuthoratativeDocuments_AuthoratativeDocumentId",
                        column: x => x.AuthoratativeDocumentId,
                        principalTable: "AuthoratativeDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectAuthoratativeDocuments_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectComponents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    ProjectComponentsId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ProjectComponents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectComponents_AbpDynamicPropertyValues_ProjectComponentsId",
                        column: x => x.ProjectComponentsId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectComponents_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectCountries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_ProjectCountries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectCountries_AbpDynamicPropertyValues_CountryId",
                        column: x => x.CountryId,
                        principalTable: "AbpDynamicPropertyValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectCountries_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeamMemberExternals",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    TeamMembersExternalId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProjectTeamMemberExternals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMemberExternals_Employees_TeamMembersExternalId",
                        column: x => x.TeamMembersExternalId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMemberExternals_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeamMemberProjects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    TeamMembersId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProjectTeamMemberProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMemberProjects_Employees_TeamMembersId",
                        column: x => x.TeamMembersId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMemberProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<long>(type: "bigint", nullable: true),
                    TeamMembersInternalId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_ProjectTeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMembers_Employees_TeamMembersInternalId",
                        column: x => x.TeamMembersInternalId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectTeamMembers_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaskAssociatedProjects",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddTaskId = table.Column<long>(type: "bigint", nullable: true),
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
                    table.PrimaryKey("PK_TaskAssociatedProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskAssociatedProjects_AddTasks_AddTaskId",
                        column: x => x.AddTaskId,
                        principalTable: "AddTasks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TaskAssociatedProjects_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_AssignedToId",
                table: "AddTasks",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_AssignedUserId",
                table: "AddTasks",
                column: "AssignedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_LinkedToId",
                table: "AddTasks",
                column: "LinkedToId");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_RequestedById",
                table: "AddTasks",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_RiskLevelId",
                table: "AddTasks",
                column: "RiskLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_StatusId",
                table: "AddTasks",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AddTasks_TaskTypeId",
                table: "AddTasks",
                column: "TaskTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GrcPrograms_LockThreatOrganizationId",
                table: "GrcPrograms",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_GrcPrograms_ProgramDirectorId",
                table: "GrcPrograms",
                column: "ProgramDirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_GrcPrograms_ProgramSponsorId",
                table: "GrcPrograms",
                column: "ProgramSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingAbsenteeUsers_EmployeeId",
                table: "MeetingAbsenteeUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingAbsenteeUsers_MeetingId",
                table: "MeetingAbsenteeUsers",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingAttendUsers_EmployeeId",
                table: "MeetingAttendUsers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingAttendUsers_MeetingId",
                table: "MeetingAttendUsers",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CountryId",
                table: "Meetings",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_EmployeeId",
                table: "Meetings",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingClassificationId",
                table: "Meetings",
                column: "MeetingClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MeetingTypeId",
                table: "Meetings",
                column: "MeetingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_OrganizerId",
                table: "Meetings",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingTasks_AddTaskId",
                table: "MeetingTasks",
                column: "AddTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingTasks_MeetingId",
                table: "MeetingTasks",
                column: "MeetingId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramAuthoritativeDocuments_AuthoratativeDocumentId",
                table: "ProgramAuthoritativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramAuthoritativeDocuments_GrcProgramId",
                table: "ProgramAuthoritativeDocuments",
                column: "GrcProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCoordinators_GrcProgramId",
                table: "ProgramCoordinators",
                column: "GrcProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCoordinators_ProgramCoordinatorsId",
                table: "ProgramCoordinators",
                column: "ProgramCoordinatorsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCountrys_CountryId",
                table: "ProgramCountrys",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramCountrys_GrcProgramId",
                table: "ProgramCountrys",
                column: "GrcProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramTeams_GrcProgramId",
                table: "ProgramTeams",
                column: "GrcProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_ProgramTeams_ProgramTeamsId",
                table: "ProgramTeams",
                column: "ProgramTeamsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAuthoratativeDocuments_AuthoratativeDocumentId",
                table: "ProjectAuthoratativeDocuments",
                column: "AuthoratativeDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAuthoratativeDocuments_ProjectId",
                table: "ProjectAuthoratativeDocuments",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectComponents_ProjectComponentsId",
                table: "ProjectComponents",
                column: "ProjectComponentsId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectComponents_ProjectId",
                table: "ProjectComponents",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCountries_CountryId",
                table: "ProjectCountries",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectCountries_ProjectId",
                table: "ProjectCountries",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_IndustryId",
                table: "Projects",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_LockThreatOrganizationId",
                table: "Projects",
                column: "LockThreatOrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ParentProgramId",
                table: "Projects",
                column: "ParentProgramId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectDirectorId",
                table: "Projects",
                column: "ProjectDirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProjectSponsorId",
                table: "Projects",
                column: "ProjectSponsorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMemberExternals_ProjectId",
                table: "ProjectTeamMemberExternals",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMemberExternals_TeamMembersExternalId",
                table: "ProjectTeamMemberExternals",
                column: "TeamMembersExternalId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMemberProjects_ProjectId",
                table: "ProjectTeamMemberProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMemberProjects_TeamMembersId",
                table: "ProjectTeamMemberProjects",
                column: "TeamMembersId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMembers_ProjectId",
                table: "ProjectTeamMembers",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTeamMembers_TeamMembersInternalId",
                table: "ProjectTeamMembers",
                column: "TeamMembersInternalId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssociatedProjects_AddTaskId",
                table: "TaskAssociatedProjects",
                column: "AddTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAssociatedProjects_ProjectId",
                table: "TaskAssociatedProjects",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskAttachments_AddTaskId",
                table: "TaskAttachments",
                column: "AddTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskNotifications_AddTaskId",
                table: "TaskNotifications",
                column: "AddTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskNotifications_EmployeeId",
                table: "TaskNotifications",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRelatedMembers_AddTaskId",
                table: "TaskRelatedMembers",
                column: "AddTaskId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskRelatedMembers_EmployeeId",
                table: "TaskRelatedMembers",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingAbsenteeUsers");

            migrationBuilder.DropTable(
                name: "MeetingAttendUsers");

            migrationBuilder.DropTable(
                name: "MeetingTasks");

            migrationBuilder.DropTable(
                name: "ProgramAuthoritativeDocuments");

            migrationBuilder.DropTable(
                name: "ProgramCoordinators");

            migrationBuilder.DropTable(
                name: "ProgramCountrys");

            migrationBuilder.DropTable(
                name: "ProgramTeams");

            migrationBuilder.DropTable(
                name: "ProjectAuthoratativeDocuments");

            migrationBuilder.DropTable(
                name: "ProjectComponents");

            migrationBuilder.DropTable(
                name: "ProjectCountries");

            migrationBuilder.DropTable(
                name: "ProjectTeamMemberExternals");

            migrationBuilder.DropTable(
                name: "ProjectTeamMemberProjects");

            migrationBuilder.DropTable(
                name: "ProjectTeamMembers");

            migrationBuilder.DropTable(
                name: "TaskAssociatedProjects");

            migrationBuilder.DropTable(
                name: "TaskAttachments");

            migrationBuilder.DropTable(
                name: "TaskNotifications");

            migrationBuilder.DropTable(
                name: "TaskRelatedMembers");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "AddTasks");

            migrationBuilder.DropTable(
                name: "GrcPrograms");
        }
    }
}
