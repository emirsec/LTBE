using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Employees;
using Lockthreat.Findings;
using Lockthreat.FindingsInformation;
using Lockthreat.OrganizationSetups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.InternalControls
{
    [Table("InternalControls")]
    public  class InternalControl : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string InternalControlId { get; set; }

        public string ICTitle { get; set; }

        public int? FrequencyTypeId  { get; set; }
        public DynamicPropertyValue FrequencyType { get; set; }

        public int? InternalAuditControlId  { get; set; }
        public DynamicPropertyValue InternalAuditControl { get; set; }

        public string Notes { get; set; }

        public long? FindingId  { get; set; }
        public Finding Finding  { get; set; }

        public int? ControlFrequencyId  { get; set; }
        public DynamicPropertyValue ControlFrequency  { get; set; }

        public int? ControlStatusId  { get; set; }
        public DynamicPropertyValue ControlStatus  { get; set; }

        public string TestingProcedure { get; set; }

        public string ICId { get; set; }
        public int? IcTypeId   { get; set; }
        public DynamicPropertyValue IcType  { get; set; }
        
        public string ControlDescription { get; set; }

        public int? AutomationId  { get; set; }
        public DynamicPropertyValue Automation { get; set; }
        
        public int? SampleSize { get; set; }
        public int? PriorityId  { get; set; }
        public DynamicPropertyValue Priority { get; set; }

        public int? ComplianceStatusId  { get; set; }
        public DynamicPropertyValue ComplianceStatus { get; set; }

        public long? EmployeeId  { get; set; }
        public Employee Employee  { get; set; }

        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization  { get; set; }

        
    }
}
