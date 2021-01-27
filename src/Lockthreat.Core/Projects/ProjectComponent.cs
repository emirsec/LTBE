using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.Projects 
{
  public class ProjectComponent : FullAuditedEntity<long>
    {
        public long? ProjectId  { get; set; }
        public Project Project { get; set; }

        public int? ProjectComponentsId   { get; set; }
        public DynamicPropertyValue ProjectComponents  { get; set; }
    }
}
