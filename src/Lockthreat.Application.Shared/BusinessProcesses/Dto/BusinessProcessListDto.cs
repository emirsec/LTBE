using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Employee.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.BusinessProcesses.Dto
{
    public class BusinessProcessListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string BusinessProcessId { get; set; } 
        public string BusinessProcessName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public GetOrganizationForEditDto LockThreatOrganization { get; set; }
        public long? ProcessOwnerId { get; set; }
        public GetEmployeeForEditDto ProcessOwner { get; set; }
        public int? StatusId { get; set; }
        public DynamicPropertyValue Status { get; set; }
        public int? ProcessTypeId { get; set; }
        public DynamicPropertyValue ProcessType { get; set; }
        public int? ProcessPriorityId { get; set; }
        public DynamicPropertyValue ProcessPriority { get; set; }
        public string Description { get; set; }
    }
}
