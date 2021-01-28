using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.KeyPerformanceIndicator.Dto
{
    public class KeyPerformanceIndicatorListDto : EntityDto<long>, IPassivable, IHasCreationTime
    {
        public string KeyPerformanceIndicatorId { get; set; } 
        [Required]
        public string KeyPerformanceIndicatorTitle { get; set; } 
        public int? StatusId { get; set; }
        public DynamicPropertyValue Status { get; set; } 
        public int? FrequencyId { get; set; }
        public DynamicPropertyValue Frequency { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationTime { get; set; }
        public string Description { get; set; }
    }
}
