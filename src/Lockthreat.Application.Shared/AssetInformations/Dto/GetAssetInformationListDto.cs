using Abp.Application.Services.Dto;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.AssetInformations.Dto
{
   public class GetAssetInformationListDto : EntityDto<long>
    {
        public int? TenantId { get; set; }
        public string AssetId { get; set; }
        public string AssetTitle { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public int? CountryId { get; set; }
        public DynamicPropertyValue Country { get; set; }

        public int? AssetIdLV { get; set; }

        public int? AssetTypeId { get; set; }
        public DynamicPropertyValue AssetType { get; set; }
        public int? AssetCategoryId { get; set; }
        public DynamicPropertyValue AssetCategory { get; set; }

        public int? AssetLabelId { get; set; }
        public DynamicPropertyValue AssetLabel { get; set; }

        public long? LockThreatOrganizationId { get; set; }
        public GetOrganizationDto LockThreatOrganization { get; set; }
        public long? EmployeeId { get; set; }
        public BusinessServiceOwner Employee { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality { get; set; }

        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility { get; set; }

        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity { get; set; }
        public int? OtherId { get; set; }
        public DynamicPropertyValue Other { get; set; }
    }
}
