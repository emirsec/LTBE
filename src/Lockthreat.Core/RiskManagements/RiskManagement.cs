using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.OrganizationSetups;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.RiskManagements
{
    public class RiskManagement : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string RiskId { get; set; }

        [Required]
        public string RiskTitle { get; set; }

        public string Description { get; set; }

        public Criticality Criticality { get; set; }

        public DateTime? LastEvaluationDate { get; set; }

        public string RiskTriggerEvent { get; set; }

        public int? RiskTypeId { get; set; }
        public DynamicPropertyValue RiskType { get; set; }

        public int? RiskCategoryId { get; set; }
        public DynamicPropertyValue RiskCategory { get; set; }

        public int? RiskSourceId { get; set; }
        public DynamicPropertyValue RiskSource { get; set; }

        public int? RiskStateId { get; set; }
        public DynamicPropertyValue RiskState { get; set; }

        public int? RiskStatusId { get; set; }
        public DynamicPropertyValue RiskStatus { get; set; }

        public long? CompanyNameId { get; set; }
        public LockThreatOrganization CompanyName { get; set; }
        public long? RiskOwnerId { get; set; }
        public Employee RiskOwner { get; set; }

        public long? RiskManagerId { get; set; }
        public Employee RiskManager { get; set; }

        public long? BusinessUnitId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public int? RiskScoringMethodId { get; set; }
        public DynamicPropertyValue RiskScoringMethod { get; set; }

        public DateTime? NextEvaluation { get; set; }
        public DateTime? NextEvaluationIRRBased { get; set; }

        public int? RiskLikelihoodId { get; set; }
        public DynamicPropertyValue RiskLikelihood { get; set; }

        public int? RiskImpactId { get; set; }
        public DynamicPropertyValue RiskLiRiskImpactkelihood { get; set; }
        public int? EvaluationFrequency { get; set; }

        public int? RiskScore { get; set; }


        public int? PersistenceId { get; set; }
        public DynamicPropertyValue Persistence { get; set; }
        public int? VelocityId { get; set; }
        public DynamicPropertyValue Velocity { get; set; }

        public int? ResidualRiskId { get; set; }
        public DynamicPropertyValue ResidualRisk { get; set; }

        public int? InherentRiskId { get; set; }
        public DynamicPropertyValue InherentRisk { get; set; }
        public int? RiskTreatmentId { get; set; }
        public DynamicPropertyValue RiskTreatment { get; set; }

        public int? DurationId { get; set; }
        public DynamicPropertyValue Duration { get; set; }

        public int? ExpectedLoss { get; set; }




    }
}
