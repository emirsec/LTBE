using Abp.IdentityServer4vNext;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Lockthreat.Authorization.Delegation;
using Lockthreat.Authorization.Roles;
using Lockthreat.Authorization.Users;
using Lockthreat.Chat;
using Lockthreat.Editions;
using Lockthreat.Friendships;
using Lockthreat.MultiTenancy;
using Lockthreat.MultiTenancy.Accounting;
using Lockthreat.MultiTenancy.Payments;
using Lockthreat.Storage;
using Lockthreat.OrganizationSetups;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.BusinessServices;
using Lockthreat.ITServices;
using Lockthreat.BusinessProcesses;
using Lockthreat.AuthoratativeDocuments;
using Lockthreat.AddTasks;
using Lockthreat.Meetings;
using Lockthreat.Projects;
using Lockthreat.GrcPrograms;
using Lockthreat.ApplicationConfigurations;
using Lockthreat.AssetInformations;
using Lockthreat.Audits;
using Lockthreat.Vendors;
using Lockthreat.FacilitieDatacenters;
using Lockthreat.FacilitiesDatacenters;
using Lockthreat.Findings;
using Lockthreat.SystemApplications;
using Lockthreat.VirtualAssets;
using Lockthreat.HardwareAssets;
using Lockthreat.FindingsInformation;
using Lockthreat.InternalControls;
using Lockthreat.Incidents;
using Lockthreat.ControlOperatingTests;
using Lockthreat.StrategicObjectives;
using Lockthreat.RiskManagements;
using Lockthreat.ControlDesigns;

namespace Lockthreat.EntityFrameworkCore
{
    public class LockthreatDbContext : AbpZeroDbContext<Tenant, Role, User, LockthreatDbContext>, IAbpPersistedGrantDbContext
    {



        public virtual DbSet<ControlDesign> ControlDesigns { get; set; }
        public virtual DbSet<RiskManagement> RiskManagements { get; set; }
        public virtual DbSet<StrategicObjective> StrategicObjectives { get; set; }
        public virtual DbSet<ControlOperatingTest> ControlOperatingTests { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<InternalControl> InternalControls { get; set; }
        public virtual DbSet<FindingAssetInformation> FindingAssetInformations { get; set; }
        public virtual DbSet<FindingAuthoratativeSource> FindingAuthoratativeSources { get; set; }
        public virtual DbSet<FindingBusinessUnit> FindingBusinessUnits { get; set; }
        public virtual DbSet<FindingControlDesign> FindingControlDesigns { get; set; } 
        public virtual DbSet<FindingRiskRegister> FindingRiskRegisters { get; set; }
        public virtual DbSet<FindingStrategicObjective> FindingStrategicObjectives { get; set; }
        public virtual DbSet<FindingSystemsApplication> FindingSystemsApplications { get; set; }
        public virtual DbSet<FindingControlOperating> FindingControlOperatings { get; set; }
        public virtual DbSet<FindingFacilitieDatacenter> FindingFacilitieDatacenters { get; set; }
        public virtual DbSet<FindingHardwareAsset> FindingHardwareAssets { get; set; }
        public virtual DbSet<FindingIncident> FindingIncidents { get; set; }
        public virtual DbSet<FindingInternalControl> FindingInternalControls { get; set; }
        public virtual DbSet<FindingOrganization> FindingOrganizations { get; set; }
        public virtual DbSet<FindingVendor> FindingVendors { get; set; }
        public virtual DbSet<FindingVirtualHost> FindingVirtualHosts { get; set; }



        public virtual DbSet<HardwareAsset> HardwareAssets { get; set; }
        public virtual DbSet<HardwareAssetBusinessService> HardwareAssetBusinessServices { get; set; }
        public virtual DbSet<HardwareAssetITservice> HardwareAssetITservices { get; set; }
        public virtual DbSet<HardwareAssetBusinessprocess> HardwareAssetBusinessProcess { get; set; }
        public virtual DbSet<VirtualAsset> VirtualAssets { get; set; }
        public virtual DbSet<VirtualAssetBusinessService> VirtualAssetBusinessServices { get; set; }
        public virtual DbSet<VirtualAssetBusinessprocess> VirtualAssetBusinessprocess { get; set; }
        public virtual DbSet<VirtualAssetITservice> VirtualAssetITservices { get; set; }
        public virtual DbSet<FindingVirtualMachine> FindingVirtualMachines { get; set; }
        public virtual DbSet<Finding> Findings { get; set; }
        public virtual DbSet<SystemApplicationService> SystemApplicationServices { get; set; }
        public virtual DbSet<SysteamApplicationBusinessProcess> SysteamApplicationBusinessProcess { get; set; }
        public virtual DbSet<SysteamApplicationITservice> SysteamApplicationITservices { get; set; }
        public virtual DbSet<SystemApplication> SystemApplications { get; set; }
        public virtual DbSet<FacilitieDatacenterITService> FacilitieDatacenterITServices { get; set; }
        public virtual DbSet<FacilitieDatacenterService> FacilitieDatacenterServices { get; set; }
        public virtual DbSet<FacilitieDatacenterProcess> FacilitieDatacenterProcess { get; set; }
        public virtual DbSet<FacilitieDatacenter> FacilitieDatacenters { get; set; }
        public virtual DbSet<VendorProductService> VendorProductServices { get; set; }
        public virtual DbSet<AuditSystemApplication> AuditSystemApplications { get; set; }
        public virtual DbSet<AuditFinding> AuditFindings { get; set; }
        public virtual DbSet<AuditVendor> AuditVendors { get; set; }
        public virtual DbSet<AuditAttachment> AuditAttachments { get; set; }
        public virtual DbSet<AuditTeam> AuditTeams { get; set; }
        public virtual DbSet<AuditFacilitieDatacenter> AuditFacilitieDatacenters { get; set; }
        public virtual DbSet<AuditBusinessService> AuditBusinessServices { get; set; }
        public virtual DbSet<AuditBusinessProcess> AuditBusinessProcess { get; set; }
        public virtual DbSet<AuditAuditor> AuditAuditors { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AssetInformationBusinessService> AssetInformationBusinessServices { get; set; }
        public virtual DbSet<AssetInformationBusinessprocess> AssetInformationBusinessprocess { get; set; }
        public virtual DbSet<AssetInformationITservice> AssetInformationITservices { get; set; }
        public virtual DbSet<AssetInformation> AssetInformations { get; set; }
        public virtual DbSet<ApplicationConfiguration> ApplicationConfigurations { get; set; }
        public virtual DbSet<ProgramAuthoritativeDocument> ProgramAuthoritativeDocuments { get; set; }
        public virtual DbSet<ProgramCoordinator> ProgramCoordinators { get; set; }
        public virtual DbSet<ProgramTeam> ProgramTeams { get; set; }
        public virtual DbSet<ProgramCountry> ProgramCountrys { get; set; }
        public virtual DbSet<ProjectTeamMemberProject> ProjectTeamMemberProjects { get; set; }
        public virtual DbSet<ProjectTeamMemberExternal> ProjectTeamMemberExternals { get; set; }
        public virtual DbSet<ProjectTeamMember> ProjectTeamMembers { get; set; }
        public virtual DbSet<ProjectCountries> ProjectCountries { get; set; }
        public virtual DbSet<ProjectComponent> ProjectComponents { get; set; }
        public virtual DbSet<ProjectAuthoratativeDocument> ProjectAuthoratativeDocuments { get; set; }
        public virtual DbSet<GrcProgram> GrcPrograms { get; set; }
        public virtual DbSet<MeetingAttendUser> MeetingAttendUsers { get; set; }
        public virtual DbSet<MeetingAbsenteeUser> MeetingAbsenteeUsers { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<MeetingTask> MeetingTasks { get; set; }
        public virtual DbSet<TaskNotification> TaskNotifications { get; set; }
        public virtual DbSet<TaskAttachment> TaskAttachments { get; set; }
        public virtual DbSet<TaskRelatedMember> TaskRelatedMembers { get; set; }
        public virtual DbSet<TaskAssociatedProject> TaskAssociatedProjects { get; set; }
        public virtual DbSet<AddTask> AddTasks { get; set; }
        public virtual DbSet<AuthoratativeDocument> AuthoratativeDocuments { get; set; }
        public virtual DbSet<BusinessProcessUnit> BusinessProcessUnits { get; set; }
        public virtual DbSet<BusinessProcessService> BusinessProcessServices { get; set; }
        public virtual DbSet<BusinessProcessAuthoratativeDocument> BusinessProcessAuthoratativeDocuments { get; set; }
        public virtual DbSet<BusinessProcess> BusinessProcess { get; set; }
        public virtual DbSet<BusinessITService> BusinessITServices { get; set; }
        public virtual DbSet<BusinessServiceUnit> BusinessServiceUnits { get; set; }
        public DbSet<ITServiceBusinessUnit> ITServiceBusinessUnits { get; set; }
        public DbSet<ITServiceBusinessService> ITServiceBusinessServices { get; set; }
        public virtual DbSet<ITService> ITServices { get; set; }
        public virtual DbSet<BusinessService> BusinessServices { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<BusinessUnit> BusinessUnits { get; set; }
        public virtual DbSet<LockThreatOrganization> LockThreatOrganizations { get; set; }


        /* Define an IDbSet for each entity of the application */

        public virtual DbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual DbSet<Friendship> Friendships { get; set; }

        public virtual DbSet<ChatMessage> ChatMessages { get; set; }

        public virtual DbSet<SubscribableEdition> SubscribableEditions { get; set; }

        public virtual DbSet<SubscriptionPayment> SubscriptionPayments { get; set; }

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<PersistedGrantEntity> PersistedGrants { get; set; }

        public virtual DbSet<SubscriptionPaymentExtensionData> SubscriptionPaymentExtensionDatas { get; set; }

        public virtual DbSet<UserDelegation> UserDelegations { get; set; }

        public LockthreatDbContext(DbContextOptions<LockthreatDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BinaryObject>(b =>
            {
                b.HasIndex(e => new { e.TenantId });
            });

            modelBuilder.Entity<ChatMessage>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId, e.ReadState });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.TargetUserId, e.ReadState });
                b.HasIndex(e => new { e.TargetTenantId, e.UserId, e.ReadState });
            });

            modelBuilder.Entity<Friendship>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.UserId });
                b.HasIndex(e => new { e.TenantId, e.FriendUserId });
                b.HasIndex(e => new { e.FriendTenantId, e.UserId });
                b.HasIndex(e => new { e.FriendTenantId, e.FriendUserId });
            });

            modelBuilder.Entity<Tenant>(b =>
            {
                b.HasIndex(e => new { e.SubscriptionEndDateUtc });
                b.HasIndex(e => new { e.CreationTime });
            });

            modelBuilder.Entity<SubscriptionPayment>(b =>
            {
                b.HasIndex(e => new { e.Status, e.CreationTime });
                b.HasIndex(e => new { PaymentId = e.ExternalPaymentId, e.Gateway });
            });

            modelBuilder.Entity<SubscriptionPaymentExtensionData>(b =>
            {
                b.HasQueryFilter(m => !m.IsDeleted)
                    .HasIndex(e => new { e.SubscriptionPaymentId, e.Key, e.IsDeleted })
                    .IsUnique();
            });

            modelBuilder.Entity<UserDelegation>(b =>
            {
                b.HasIndex(e => new { e.TenantId, e.SourceUserId });
                b.HasIndex(e => new { e.TenantId, e.TargetUserId });
            });

            modelBuilder.ConfigurePersistedGrantEntity();
        }
    }
}
