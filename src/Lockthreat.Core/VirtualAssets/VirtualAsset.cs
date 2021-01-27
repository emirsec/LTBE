using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.HardwareAssets;
using Lockthreat.OrganizationSetups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lockthreat.VirtualAssets
{
  public  class VirtualAsset : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string VirtualAssetId { get; set; }

        [Required]
        public string VirtualAssetName { get; set; }

        public string VirtualAssetUniqueIdentity { get; set; }

        public bool VirtualMachine { get; set; }

        public string Description { get; set; }

        public long? ParentVirtualHostId  { get; set; }    
        public long? HostedServerNameId  { get; set; }
        public HardwareAsset HostedServerName { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization  { get; set; }
        public long? BusinessUnitId { get; set; }
        public BusinessUnit BusinessUnit { get; set; }
        public long? BusinessUnitGaurdianId { get; set; }
        public BusinessUnit BusinessUnitGaurdian { get; set; }

        public long? BusinessOwnerId { get; set; }
        public Employee BusinessOwner { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality { get; set; }
        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility { get; set; }
        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity { get; set; }
        public int? OthersId { get; set; }
        public DynamicPropertyValue Others { get; set; }

        public ICollection<VirtualAssetITservice> SelectedVirtualAssetITservices  { get; set; }
        public ICollection<VirtualAssetBusinessprocess> SelectedVirtualAssetBusinessprocess  { get; set; }
        public ICollection<VirtualAssetBusinessService> SelectedVirtualAssetBusinessServices  { get; set; }

    }
}
