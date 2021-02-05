using Abp.Domain.Repositories;
using Abp.DynamicEntityProperties;
using AutoMapper;
using Lockthreat.Common;
using Lockthreat.Countries.Dto;
using Lockthreat.DynamicEntityProperties.Dto;
using Lockthreat.Meetings.Dto;
using Lockthreat.OrganizationSetup.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockthreat.Countries
{
    public class CountriesAppservice : LockthreatAppServiceBase, ICountriesAppservice
    {

        private readonly IRepository<DynamicPropertyValue> _DynamicParameterValueRepository;
        private readonly IRepository<DynamicProperty> _dynamicParameterManager;
        private readonly ICommonMethodAppService _commonMethodAppService;

        public CountriesAppservice(
          IRepository<DynamicPropertyValue> DynamicParameterValueRepository,
          IRepository<DynamicProperty> dynamicParameterManager,
            ICommonMethodAppService commonMethodAppService
          )
        {
            _DynamicParameterValueRepository = DynamicParameterValueRepository;
            _dynamicParameterManager = dynamicParameterManager;
            _commonMethodAppService = commonMethodAppService;
        }
        public async Task<List<CountryDto>> GetAll()
        {
            var getCountries = new List<CountryDto>();
            var query = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("country");
            getCountries = ObjectMapper.Map<List<CountryDto>>(query);
            return getCountries;
        }
        public async Task<List<GetDynamicValueDto>> GetAllConfidentiality()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("confidentiality");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAllServiceType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("service type");
            return result;            
        }
        public async Task<List<GetDynamicValueDto>> GetAllIntergrity()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("integrity");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAllOthers()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("others");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAvailibility()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("availibility");
            return result;
        }
        public async Task<List<DynamicNameValueDto>> GetIndustrySectors()
        {
            var getIndustrySectors = new List<DynamicNameValueDto>();
            var query = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("industry sector");
            getIndustrySectors = ObjectMapper.Map<List<DynamicNameValueDto>>(query);
            return getIndustrySectors;
        }
        public async Task<List<DynamicNameValueDto>> GetComponents()
        {
            var getComponents = new List<DynamicNameValueDto>();
            try
            {
                var getcheckId = _dynamicParameterManager.FirstOrDefault(x => x.PropertyName.ToLower().Trim() == "Components");
                if (getcheckId != null)
                {

                    var getother = await _DynamicParameterValueRepository.GetAll().Where(l => l.DynamicPropertyId == getcheckId.Id)
                        .Select(x => new DynamicNameValueDto()
                        {
                            Id = x.Id,
                            Name = x.Value,
                        }).ToListAsync();

                    if (getother.Count() != 0)
                    {
                        getComponents = ObjectMapper.Map<List<DynamicNameValueDto>>(getother);
                    }
                    return getComponents;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return getComponents;
        }
        public async Task<List<GetDynamicValueDto>> GetAllGrade()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("employee grade");
            return result;            
        }
        public async Task<List<GetDynamicValueDto>> GetAllUserType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("user type");
            return result;            
        }
        public async Task<List<GetDynamicValueDto>> GetAllStrategicGoal()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("strategic goal");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAllStrategicType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("strategic type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAllStrategicStatus()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("strategic status");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAllRiskGroup()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("risk group");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetKeyRiskStatus()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("status");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetFrequency()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("frequency");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetProcessType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("process type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetSLA()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("sla");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetRiviewperiod()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("riview period");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetProcessStatus()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("process status");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetActivity()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("activity");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetProcessPriority()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("process priority");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetMeeetingType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Meeting Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetMeetingClassification()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Meeting Classification");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetRiskLevel()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Risk Level");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetTaskLinked()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Task Link To");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetTaskType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Task Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetFacilityType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Facility Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAssetType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Asset Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAssetCategorys()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Asset Category");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAssetLabels()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Asset Label");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAuditYear()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Fiscal Year");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetAuditArea()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Audit Area");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetExceptionType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetExceptionReviewStatus()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Review Status");
            return result;
        }
        public async Task<List<FacilitieIdDto>> GetFacilitieId()
        {
            var getid = new List<FacilitieIdDto>();
            try
            {
                getid = await _DynamicParameterValueRepository.GetAll().Where(l => l.Value.ToLower().Trim() == ("Meeting and Board Room").ToLower().Trim() || (l.Value.ToLower().Trim() == ("Offices").ToLower().Trim())).Select(x => new FacilitieIdDto { Id = x.Id }).ToListAsync();
                return getid;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<GetDynamicValueDto>> GetVendorType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Vendor Type");
            return result;
        }

        public async Task<List<GetDynamicValueDto>> GetIndustroy()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Industry");
            return result;
        }

        public async Task<List<GetDynamicValueDto>> GetVendorProductType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Product Type");
            return result;
        }

        public async Task<List<GetDynamicValueDto>> GetContactType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Contact Type");
            return result;
        }

        public async Task<List<GetDynamicValueDto>> GetContractType()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Contract Type");
            return result;
        }
        public async Task<List<GetDynamicValueDto>> GetContractCategory()
        {
            var result = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("Contract Category");
            return result;
        }

    }

}
