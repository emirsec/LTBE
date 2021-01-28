using Abp.Application.Services.Dto;
using Abp.DynamicEntityProperties;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.HardwareAssets.Dto
{
  public  class HardwareAssetListDto : EntityDto<long>
    {
        public int? TenantId { get; set; }

        public string AssetId { get; set; }

        public string HardwareAssetName { get; set; }

        public string Description { get; set; }

        public string AssetHardwareId { get; set; }

        public long? LocationsId { get; set; }

        public FacilitieDatacenterListDto Locations { get; set; }
        public long? LockThreatOrganizationId { get; set; }
        public GetOrganizationDto LockThreatOrganization { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality { get; set; }

        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility { get; set; }

        public int? OthersId { get; set; }
        public DynamicPropertyValue Others { get; set; }

        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity { get; set; }

    }
}
