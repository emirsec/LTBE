using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.DynamicEntityProperties.Dto
{
  public  class GetDynamicValueDto
    {
        public int Id { get; set; }

        public virtual string Value { get; set; }
    }
}
