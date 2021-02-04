using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.DynamicEntityProperties;
using Abp.EntityHistory;
using Abp.Localization;
using Abp.Notifications;
using Abp.Organizations;
using Abp.UI.Inputs;
using Abp.Webhooks;
using AutoMapper;
using Lockthreat.Auditing.Dto;
using Lockthreat.Authorization.Accounts.Dto;
using Lockthreat.Authorization.Delegation;
using Lockthreat.Authorization.Permissions.Dto;
using Lockthreat.Authorization.Roles;
using Lockthreat.Authorization.Roles.Dto;
using Lockthreat.Authorization.Users;
using Lockthreat.Authorization.Users.Delegation.Dto;
using Lockthreat.Authorization.Users.Dto;
using Lockthreat.Authorization.Users.Importing.Dto;
using Lockthreat.Authorization.Users.Profile.Dto;
using Lockthreat.Business.Dto;
using Lockthreat.Chat;
using Lockthreat.Chat.Dto;
using Lockthreat.Contacts.Dto;
using Lockthreat.DynamicEntityProperties.Dto;
using Lockthreat.Editions;
using Lockthreat.Editions.Dto;
using Lockthreat.Friendships;
using Lockthreat.Friendships.Cache;
using Lockthreat.Friendships.Dto;
using Lockthreat.GRCPrograms.Dto;
using Lockthreat.Localization.Dto;
using Lockthreat.MultiTenancy;
using Lockthreat.MultiTenancy.Dto;
using Lockthreat.MultiTenancy.HostDashboard.Dto;
using Lockthreat.MultiTenancy.Payments;
using Lockthreat.MultiTenancy.Payments.Dto;
using Lockthreat.Notifications.Dto;
using Lockthreat.Organizations.Dto;
using Lockthreat.Sessions.Dto;
using Lockthreat.WebHooks.Dto;

namespace Lockthreat
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            //Inputs
            configuration.CreateMap<CheckboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<SingleLineStringInputType, FeatureInputTypeDto>();
            configuration.CreateMap<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<IInputType, FeatureInputTypeDto>()
                .Include<CheckboxInputType, FeatureInputTypeDto>()
                .Include<SingleLineStringInputType, FeatureInputTypeDto>()
                .Include<ComboboxInputType, FeatureInputTypeDto>();
            configuration.CreateMap<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<ILocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>()
                .Include<StaticLocalizableComboboxItemSource, LocalizableComboboxItemSourceDto>();
            configuration.CreateMap<LocalizableComboboxItem, LocalizableComboboxItemDto>();
            configuration.CreateMap<ILocalizableComboboxItem, LocalizableComboboxItemDto>()
                .Include<LocalizableComboboxItem, LocalizableComboboxItemDto>();

            //Chat
            configuration.CreateMap<ChatMessage, ChatMessageDto>();
            configuration.CreateMap<ChatMessage, ChatMessageExportDto>();

            //Feature
            configuration.CreateMap<FlatFeatureSelectDto, Feature>().ReverseMap();
            configuration.CreateMap<Feature, FlatFeatureDto>();

            //Role
            configuration.CreateMap<RoleEditDto, Role>().ReverseMap();
            configuration.CreateMap<Role, RoleListDto>();
            configuration.CreateMap<UserRole, UserListRoleDto>();



            //Edition
            configuration.CreateMap<EditionEditDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<EditionCreateDto, SubscribableEdition>();
            configuration.CreateMap<EditionSelectDto, SubscribableEdition>().ReverseMap();
            configuration.CreateMap<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<Edition, EditionInfoDto>().Include<SubscribableEdition, EditionInfoDto>();

            configuration.CreateMap<SubscribableEdition, EditionListDto>();
            configuration.CreateMap<Edition, EditionEditDto>();
            configuration.CreateMap<Edition, SubscribableEdition>();
            configuration.CreateMap<Edition, EditionSelectDto>();


            //Payment
            configuration.CreateMap<SubscriptionPaymentDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPaymentListDto, SubscriptionPayment>().ReverseMap();
            configuration.CreateMap<SubscriptionPayment, SubscriptionPaymentInfoDto>();

            //Permission
            configuration.CreateMap<Permission, FlatPermissionDto>();
            configuration.CreateMap<Permission, FlatPermissionWithLevelDto>();

            //Language
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageEditDto>();
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageListDto>();
            configuration.CreateMap<NotificationDefinition, NotificationSubscriptionWithDisplayNameDto>();
            configuration.CreateMap<ApplicationLanguage, ApplicationLanguageEditDto>()
                .ForMember(ldto => ldto.IsEnabled, options => options.MapFrom(l => !l.IsDisabled));

            //Tenant
            configuration.CreateMap<Tenant, RecentTenant>();
            configuration.CreateMap<Tenant, TenantLoginInfoDto>();
            configuration.CreateMap<Tenant, TenantListDto>();
            configuration.CreateMap<TenantEditDto, Tenant>().ReverseMap();
            configuration.CreateMap<CurrentTenantInfoDto, Tenant>().ReverseMap();

            //User
            configuration.CreateMap<User, UserEditDto>()
                .ForMember(dto => dto.Password, options => options.Ignore())
                .ReverseMap()
                .ForMember(user => user.Password, options => options.Ignore());
            configuration.CreateMap<User, UserLoginInfoDto>();
            configuration.CreateMap<User, UserListDto>();
            configuration.CreateMap<User, ChatUserDto>();
            configuration.CreateMap<User, OrganizationUnitUserListDto>();
            configuration.CreateMap<Role, OrganizationUnitRoleListDto>();
            configuration.CreateMap<CurrentUserProfileEditDto, User>().ReverseMap();
            configuration.CreateMap<UserLoginAttemptDto, UserLoginAttempt>().ReverseMap();
            configuration.CreateMap<ImportUserDto, User>();

            //AuditLog
            configuration.CreateMap<AuditLog, AuditLogListDto>();
            configuration.CreateMap<EntityChange, EntityChangeListDto>();
            configuration.CreateMap<EntityPropertyChange, EntityPropertyChangeDto>();

            //Friendship
            configuration.CreateMap<Friendship, FriendDto>();
            configuration.CreateMap<FriendCacheItem, FriendDto>();

            //OrganizationUnit
            configuration.CreateMap<OrganizationUnit, OrganizationUnitDto>();

            //Webhooks
            configuration.CreateMap<WebhookSubscription, GetAllSubscriptionsOutput>();
            configuration.CreateMap<WebhookSendAttempt, GetAllSendAttemptsOutput>()
                .ForMember(webhookSendAttemptListDto => webhookSendAttemptListDto.WebhookName,
                    options => options.MapFrom(l => l.WebhookEvent.WebhookName))
                .ForMember(webhookSendAttemptListDto => webhookSendAttemptListDto.Data,
                    options => options.MapFrom(l => l.WebhookEvent.Data));

            configuration.CreateMap<WebhookSendAttempt, GetAllSendAttemptsOfWebhookEventOutput>();

            configuration.CreateMap<DynamicProperty, DynamicPropertyDto>().ReverseMap();
            configuration.CreateMap<DynamicPropertyValue, DynamicPropertyValueDto>().ReverseMap();
            configuration.CreateMap<DynamicEntityProperty, DynamicEntityPropertyDto>()
                .ForMember(dto => dto.DynamicPropertyName,
                    options => options.MapFrom(entity => entity.DynamicProperty.DisplayName));
            configuration.CreateMap<DynamicEntityPropertyDto, DynamicEntityProperty>();

            configuration.CreateMap<DynamicEntityPropertyValue, DynamicEntityPropertyValueDto>().ReverseMap();

            //User Delegations
            configuration.CreateMap<CreateUserDelegationDto, UserDelegation>();

            /* ADD YOUR OWN CUSTOM AUTOMAPPER MAPPINGS HERE */

            configuration.CreateMap<Contacts.Contact, ContactListViewDto>().
                ForMember(x => x.ContactId, option => option.MapFrom(y => y.ContactId)).
                ForMember(x => x.FirstName, option => option.MapFrom(y => y.FirstName)).
                ForMember(x => x.LastName, option => option.MapFrom(y => y.LastName)).
                ForMember(x => x.AddressOne, option => option.MapFrom(y => y.AddressOne)).
                ForMember(x => x.City, option => option.MapFrom(y => y.City)).
                ForMember(x => x.State, option => option.MapFrom(y => y.State)).
                ForMember(x => x.jobTitle, option => option.MapFrom(y => y.jobTitle)).
                ForMember(x => x.Id, option => option.MapFrom(y => y.Id)).
                ForMember(x => x.MobileNo, option => option.MapFrom(y => y.MobileNo)).
                ForMember(x => x.PhoneNumber, option => option.MapFrom(y => y.PhoneNumber)).
                ForMember(x => x.Email, option => option.MapFrom(y => y.Email)).
                ForMember(x => x.Vendor, option => option.MapFrom(y => y.Vendor == null ? "" : y.Vendor.VendorName.ToString())).
                ForMember(x => x.LoginUser, option => option.MapFrom(y => y.LoginUser == null ? "" : y.LoginUser.Name.ToString())).
                ForMember(x => x.Country, option => option.MapFrom(y => y.Country == null ? "" : y.Country.Value.ToString())).
                ForMember(x => x.LockThreatOrganization, option => option.MapFrom(y => y.LockThreatOrganization == null ? "" : y.LockThreatOrganization.CompanyName.ToString()));

            configuration.CreateMap<GetDynamicValueDto, UnitTypeDto>().ForMember(x => x.Id, option => option.MapFrom(y => y.Id)).ForMember(x => x.Name, option => option.MapFrom(y => y.Value));
            
        }
    }
}
