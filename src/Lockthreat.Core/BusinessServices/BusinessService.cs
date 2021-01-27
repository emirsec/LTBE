using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.ITServices;
using Lockthreat.OrganizationSetups;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lockthreat.BusinessServices 
{
    [Table("BusinessServices")]
    public class BusinessService  : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string BusinessServiceId  { get; set; }

        public string BusinessServiceName { get; set; }

        public long? BusinessUnitDependentId { get; set; }
        public BusinessUnit BusinessUnitDependent  { get; set; }

        public long? BusinessUnitprimaryId  { get; set; }
        public BusinessUnit BusinessUnitprimary  { get; set; }

        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization  { get; set; }

        public long? BusinessServiceOwnerId { get; set; }
        public Employee BusinessServiceOwner  { get; set; }

        public long? BusinessServiceManagerId { get; set; }
        public Employee BusinessServiceManager  { get; set; }


        public int? ServiceTypeId  { get; set; }
        public DynamicPropertyValue ServiceType { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality  { get; set; }

        public int? IntergrityId { get; set; }
        public DynamicPropertyValue Intergrity { get; set; }

        public int? OthersId { get; set; }
        public DynamicPropertyValue Others { get; set; }

        public int? AvailibilityId  { get; set; }
        public DynamicPropertyValue Availibility { get; set; }

        public ICollection<ITServiceBusinessService> SelectedItServices  { get; set; }
        public ICollection<BusinessServiceUnit> SelectdBusinessUnits  { get; set; }

    }
}
