using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.OrganizationSetups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.ITServices
{
    [Table("ITServices")]
    public class ITService : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }

        public string ITServicesId { get; set; }

        [Required]
        public string  ITServiceName { get; set; }
     
        public int? ServiceTypeId { get; set; }
        public DynamicPropertyValue ServiceType { get; set; }
        public int? ServiceClassificationId  { get; set; }
        public DynamicPropertyValue ServiceClassification { get; set; }

        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        
        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode  { get; set; }

        public int? CountryId { get; set; }
        public DynamicPropertyValue Country { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization  { get; set; }        
        public long? ITServiceOwnerId { get; set; }
        public Employee ITServiceOwner { get; set; }
        public long? ITServiceManagerId { get; set; }
        public Employee ITServiceManager { get; set; }

        public long? BusinessUnitId  { get; set; }
        public BusinessUnit BusinessUnit { get; set; }

        public int? RegulatoryMandateId  { get; set; }
        public DynamicPropertyValue RegulatoryMandate { get; set; }
        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality  { get; set; }
        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity  { get; set; }

        public int? OthersId  { get; set; }
        public DynamicPropertyValue Others { get; set; }

        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility { get; set; }

        public ICollection<ITServiceBusinessService> SelectedITserviceBusinessServices  { get; set; }
        public ICollection<ITServiceBusinessUnit> SelectedITserviceBusinessUnit  { get; set; }
        


    }
}
