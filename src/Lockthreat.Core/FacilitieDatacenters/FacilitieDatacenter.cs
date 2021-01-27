using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.DynamicEntityProperties;
using Lockthreat.BusinessEntities;
using Lockthreat.Employees;
using Lockthreat.FacilitiesDatacenters;
using Lockthreat.OrganizationSetups;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Lockthreat.FacilitieDatacenters
{
    [Table("FacilitieDatacenters")]
    public class FacilitieDatacenter  : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get; set; }
        public string FacilityId { get; set; }
        public string FacilityName { get; set; }   
        public string FacilityAddressOne { get; set; }
        public string FacilityAddressTwo { get; set; }

        public int? FacilityTypeId  { get; set; }
        public DynamicPropertyValue FacilityType { get; set; }
        public string State { get; set; }

        public string City { get; set; }
        public string  PostalCode { get; set; }
        public int? CountryId { get; set; }
        public DynamicPropertyValue Country { get; set; }
        public long? EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public long? LockThreatOrganizationId  { get; set; }
        public LockThreatOrganization LockThreatOrganization { get; set; }
        public long? BusinessUnitOwnerId { get; set; }
        public BusinessUnit BusinessUnitOwner { get; set; }

        public long? BusinessUnitGaurdianId  { get; set; }
        public BusinessUnit BusinessUnitGaurdian  { get; set; }

        public int? ConfidentialityId { get; set; }
        public DynamicPropertyValue Confidentiality { get; set; }
        public int? IntegrityId { get; set; }
        public DynamicPropertyValue Integrity { get; set; }
        public int? AvailibilityId { get; set; }
        public DynamicPropertyValue Availibility  { get; set; }
        public int? OthersId { get; set; }
        public DynamicPropertyValue Others  { get; set; }
        public ICollection<FacilitieDatacenterITService> SelectedFacilitieDatacenterITServices  { get; set; }
        public ICollection<FacilitieDatacenterProcess> SelectedFacilitieDatacenterProcess  { get; set; }
        public ICollection<FacilitieDatacenterService> SelectedFacilitieDatacenterServices  { get; set; }

    }
}
