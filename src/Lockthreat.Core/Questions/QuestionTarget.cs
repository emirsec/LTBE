using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.Questions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.Questions 
{
  public  class QuestionTarget : FullAuditedEntity<long>
    {
        public long? QuestionId  { get; set; }
        public Question Question { get; set; }

        public int? QuestionTargetsId { get; set; }
        public DynamicPropertyValue QuestionTargets  { get; set; }
    }
}
