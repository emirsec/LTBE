using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Employees;
using Lockthreat.RiskManagements;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.RiskTreatments 
{
public   class RiskTreatment : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public  string RiskTreatmentPlanId { get; set; }

        public string RiskTreatmentTitle { get; set; }

        public long? RiskManagementId { get; set; }
        public RiskManagement RiskManagement { get; set; }

        public long? OwnerId  { get; set; }
        public Employee Owner  { get; set; }

        public int? TreatmentActionId  { get; set; }
        public DynamicPropertyValue TreatmentAction { get; set; }

        public long? MitigationOwnerId  { get; set; }
        public Employee MitigationOwner { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? DueDate { get; set; }

        public int? MitigationCost { get; set; }

        public string MitigationActivity { get; set; }

        public int? MitigationStatusId  { get; set; }
        public DynamicPropertyValue MitigationStatus { get; set; }

        public string RiskAvoidancePlan { get; set; }

        public string Notes { get; set; }

        public int? ResidualImpactRatingId  { get; set; }
        public DynamicPropertyValue ResidualImpactRating  { get; set; }

        public int? ResidualLikelihoodRatingId  { get; set; }
        public DynamicPropertyValue ResidualLikelihoodRating { get; set; }
        public string   ResidualRiskNotes { get; set; }


    }
}
