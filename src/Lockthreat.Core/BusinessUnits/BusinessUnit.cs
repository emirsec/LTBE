using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Abp.Organizations;
using Lockthreat.OrganizationSetups;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lockthreat.BusinessEntities
{
    [Table("BusinessUnits")]
    public class BusinessUnit : FullAuditedEntity<long>, IMayHaveTenant,IMayHaveOrganizationUnit
    {

        public int? TenantId { get; set; }

        public string BusinessUnitId { get; set; }

        public long? LockThreatOrganizationId  { get; set; }
        public  LockThreatOrganization LockThreatOrganization { get;set;}

        public string BusinessUnitTitle { get; set; }
        public bool IsAuditableEntity { get; set; }

        public int? UnitTypeId  { get; set; }
        public DynamicPropertyValue UnitType  { get; set; }

        public int? ParentUnit { get; set; }

       
        public virtual long? OrganizationUnitId { get; set; }

        public  long? EmpId  { get; set; }

        //....Need to add EntityHeader
    }
}
