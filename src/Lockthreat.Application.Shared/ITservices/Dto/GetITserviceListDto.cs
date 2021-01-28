using Abp.Application.Services.Dto;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessServices.Dto;
using Lockthreat.Employee.Dto;
using Lockthreat.OrganizationSetup.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lockthreat.ITservices.Dto
{   
  public class GetITserviceListDto : EntityDto<long>
        {
            public string ITServicesId { get; set; }

            public string ITServiceName { get; set; }

            public int? ServiceTypeId { get; set; }
            public DynamicPropertyValue ServiceType { get; set; }

            public int? ServiceClassificationId { get; set; }
            public DynamicPropertyValue ServiceClassification { get; set; }

            public long? LockThreatOrganizationId { get; set; }
            public GetOrganizationDto LockThreatOrganization { get; set; }

            public long? ITServiceOwnerId { get; set; }
            public GetEmployeeForEditDto ITServiceOwner { get; set; }

            public long? BusinessUnitId { get; set; }
            public BusinessUnitPrimaryDto BusinessUnit { get; set; }

            public int? ConfidentialityId { get; set; }
            public DynamicPropertyValue Confidentiality { get; set; }
            public int? IntegrityId { get; set; }
            public DynamicPropertyValue Integrity { get; set; }

            public int? OthersId { get; set; }
            public DynamicPropertyValue Others { get; set; }

            public int? AvailibilityId { get; set; }
            public DynamicPropertyValue Availibility { get; set; }


    }
    
}
