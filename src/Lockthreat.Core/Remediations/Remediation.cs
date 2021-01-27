using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Employees;
using Lockthreat.RiskManagements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.Remediations
{
    public class Remediation : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string RemediationPlanId { get; set; }

        public string PlanTitle { get; set; }

        public string Description { get; set; }

        public int? EstimatedCost { get; set; }

        public int? PriorityId { get; set; }
        public DynamicPropertyValue Priority { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? CompletionDate { get; set; }

        public int? TreatmentActionId { get; set; }
        public DynamicPropertyValue TreatmentAction { get; set; }

        public int? RemediationsTypeId { get; set; }
        public DynamicPropertyValue RemediationsType { get; set; }

        public int? SubmissionStatusId { get; set; }
        public DynamicPropertyValue SubmissionStatus { get; set; }

        public long? PlanOwnerId { get; set; }
        public Employee PlanOwner { get; set; }

        public long? PlanManagerId { get; set; }
        public Employee PlanManager { get; set; }

        public int? PlanStatusId { get; set; }
        public DynamicPropertyValue PlanStatus { get; set; }

        public int? MitigationCost { get; set; }
        public string RemediationActivity { get; set; }
        public DateTime? StartDateActual { get; set; }
        public DateTime? CompletionDateActual { get; set; }

        public long? RiskManagementId { get; set; }
        public RiskManagement RiskManagement { get; set; }

        public long? RiskManagementsId { get; set; }
        public RiskManagement RiskManagements { get; set; }

        public int? ActualCostIncurred { get; set; }

    }
}
