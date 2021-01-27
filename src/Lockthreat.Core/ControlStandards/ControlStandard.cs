using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.ControlStandards
{
  public  class ControlStandard : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string ControlId { get; set; }
        public string Source { get; set; }
        public string SourceVersion { get; set; }
        public string UCFCId  { get; set; }

        public string ControlName { get; set; }

        public string ControlStandardId { get; set; }

        public int? FrameworkObjectiveId   { get; set; }
        public DynamicPropertyValue FrameworkObjective { get; set; }

        public int? ControlClassificationId  { get; set; }
        public DynamicPropertyValue ControlClassification { get; set; }
        public int? TypeId  { get; set; }
        public DynamicPropertyValue Type { get; set; }

        public int? ControlFrequencyId  { get; set; }
        public DynamicPropertyValue ControlFrequency { get; set; }

        public int? FrequencyTypeId  { get; set; }
        public DynamicPropertyValue FrequencyType  { get; set; }

        public int? ControlCategoryId  { get; set; }
        public DynamicPropertyValue ControlCategory { get; set; }

        public int? ControlAreaId  { get; set; }
        public DynamicPropertyValue ControlArea { get; set; }

       public string  ControlObjective { get; set; }

        public string ControlDescription { get; set; }

        public string ControlRequirements { get; set; }
        public string CustomApplicability { get; set; }

        public string TestingProcedure { get; set; }

        public int? SampleSize { get; set; }


    }
}
