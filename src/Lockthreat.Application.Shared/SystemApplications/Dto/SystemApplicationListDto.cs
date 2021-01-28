using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.SystemApplications.Dto
{
  public  class SystemApplicationListDto: EntityDto<long>
    {
        public int? TenantId { get; set; }

        public string SystemId { get; set; }

        public string SystemApplicationName { get; set; }

        public string AddressOne { get; set; }

        public string AddressTwo { get; set; }

        public string State { get; set; }
        public string City { get; set; }

        public string PostalCode { get; set; }
   
        public long? LockThreatOrganizationId { get; set; }
        public GetOrganizationDto LockThreatOrganization { get; set; }

        public long? BusinessUnitId { get; set; }
        public BusinessUnitPrimaryDto BusinessUnit { get; set; }

        public long? BusinessOwnerId { get; set; }
        public BusinessServiceOwner BusinessOwner { get; set; }

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
