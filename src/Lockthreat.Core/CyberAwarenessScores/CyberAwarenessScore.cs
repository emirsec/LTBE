using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Employees;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.CyberAwarenessScores 
{
 public  class CyberAwarenessScore : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string CASId { get; set; }
        [Required]
        public string CASName { get; set; }

        public long? EmployeeId  { get; set; }
        public Employee Employee { get; set; }
        
        public int? TargetTypeId { get; set; }
        public DynamicPropertyValue TargetType { get; set; }
        public int? SatusId { get; set; }
        public DynamicPropertyValue Status { get; set; }
        public int? SourceId { get; set; }
        public DynamicPropertyValue Source { get; set; }
        public int? ScheduleId { get; set; }
        public DynamicPropertyValue Schedule { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsQuestionarieGenerated { get; set; }
    }
}
