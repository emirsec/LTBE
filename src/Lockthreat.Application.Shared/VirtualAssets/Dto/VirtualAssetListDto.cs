using Abp.Application.Services.Dto;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.VirtualAssets.Dto
{
  public  class VirtualAssetListDto : EntityDto<long>
    {
        public int? TenantId { get; set; }
        public string VirtualAssetId { get; set; }      
        public string VirtualAssetName { get; set; }
        public string VirtualAssetUniqueIdentity { get; set; }

        public bool VirtualMachine { get; set; }

        public string Description { get; set; }
        public long? ParentVirtualHostId { get; set; }
        public long? HostedServerNameId { get; set; }
        public HardwareAsseDetailListDto HostedServerName { get; set; }
        public long? LockThreatOrganizationId { get; set; }
        public GetOrganizationDto LockThreatOrganization { get; set; }
        public long? BusinessUnitId { get; set; }
        public BusinessUnitPrimaryDto BusinessUnit { get; set; }
        public long? BusinessUnitGaurdianId { get; set; }
        public BusinessUnitGaurdianDto BusinessUnitGaurdian { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality { get; set; }
        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility { get; set; }
        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity { get; set; }
        public int? OthersId { get; set; }
        public DynamicPropertyValue Others { get; set; }
    }
}
