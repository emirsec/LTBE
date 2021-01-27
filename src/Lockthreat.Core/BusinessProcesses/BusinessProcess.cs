using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.OrganizationSetups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.BusinessProcesses 
{
    [Table("BusinessProcess")]
    public  class BusinessProcess : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string BusinessProcessId { get; set; }

        [Required]
        public string BusinessProcessName { get; set; }
        
        public int? StatusId { get; set; }
        public DynamicPropertyValue Status { get; set; }

        public string Description { get; set; }
      
        public int? ProcessTypeId { get; set; }
        public DynamicPropertyValue ProcessType { get; set; }

        public int? SlaApplicableId  { get; set; }
        public DynamicPropertyValue SlaApplicable  { get; set; }

       
        public int? ActivityCycleId { get; set; }
        public DynamicPropertyValue ActivityCycle { get; set; }

        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string PostalCode { get; set; }
        public int? CountryId { get; set; }
        public DynamicPropertyValue Country  { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization  { get; set; }

        public long? ProcessManagerId { get; set; }
        public Employee ProcessManager  { get; set; }

        public long? ProcessOwnerId { get; set; }
        public Employee ProcessOwner  { get; set; }

        public long? BusinessUnitId  { get; set; }
        public BusinessUnit BusinessUnit  { get; set; }

        public int?  RegulatoryId  { get; set; }
        public DynamicPropertyValue Regulatory  { get; set; }

        public int? ProcessPriorityId { get; set; }
        public DynamicPropertyValue ProcessPriority  { get; set; }

        public int? OthersId { get; set; }
        public DynamicPropertyValue Others  { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality  { get; set; }

        public int? ReviewPeriodId  { get; set; }
        public DynamicPropertyValue ReviewPeriod { get; set; }

        public int? IntergrityId { get; set; }
        public DynamicPropertyValue Intergrity { get; set; }

        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility  { get; set; }

        public string Documents { get; set; }

        public ICollection<BusinessProcessService> SelectedBusinessProcessServices  { get; set; }
        public ICollection<BusinessProcessUnit> SelectedBusinessProcessUnits  { get; set; }
        public ICollection<BusinessProcessAuthoratativeDocument> SelectedBusinessProcessAuthorativeDocuments { get; set; }

    }
}
