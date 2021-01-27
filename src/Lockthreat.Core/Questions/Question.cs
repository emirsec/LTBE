using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.Questions
{
    public class Question : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string QuestionId { get; set; }
        [Required]

        public string QuestionnaireTitle { get; set; }

        public string SourceQuestion { get; set; }

        public string DisplayQuestion { get; set; }

        public string QuestionTitle { get; set; }

        public int? SectionId { get; set; }
        public DynamicPropertyValue Section { get; set; }

        public int? QuestionAreaId { get; set; }
        public DynamicPropertyValue QuestionArea { get; set; }

        public int? QuestionCategoryId { get; set; }
        public DynamicPropertyValue QuestionCategory { get; set; }

        public int? QuestionStatusId { get; set; }
        public DynamicPropertyValue QuestionStatus { get; set; }

        public int? AnswerTypeId { get; set; }
        public DynamicPropertyValue AnswerType { get; set; }

        public bool AnswerTypes { get; set; }

        public string AnswerValues { get; set; }

        public string AnswerText { get; set; }

        public int? AnswerPoints { get; set; }

        public int? TotalPoints { get; set; }

    }
}
