using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Abp.Runtime.Session;
using Microsoft.EntityFrameworkCore;
using Lockthreat.Common.Dto;
using Lockthreat.Editions;
using Lockthreat.Editions.Dto;
using Abp.DynamicEntityProperties;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using Lockthreat.DynamicEntityProperties.Dto;
using System;
using Lockthreat.BusinessProcesses;
using Lockthreat.BusinessEntities;
using Lockthreat.GrcPrograms;
using Lockthreat.Projects;


namespace Lockthreat.Common
{
    [AbpAuthorize]
    public class CommonMethodAppService : LockthreatAppServiceBase, ICommonMethodAppService
    {
        private readonly IRepository<DynamicPropertyValue> _dynamicPropertyValueRepository;
        private readonly IRepository<DynamicProperty> _dynamicPropertyManager;
        private readonly IRepository<BusinessProcess, long> _businessProcessRepository;
        private readonly IRepository<BusinessUnit, long> _businessUnitRepository;
        private readonly IRepository<GrcProgram, long> _programRepository;
        private readonly IRepository<Project, long> _projectsDetailsRepository;
        private readonly IRepository<Employees.Employee, long> _employessRepository;

        public CommonMethodAppService(IRepository<DynamicPropertyValue> dynamicPropertyValueRepository, IRepository<DynamicProperty> dynamicPropertyManager, IRepository<BusinessProcess, long> businessProcessRepository, IRepository<BusinessUnit, long> businessUnitRepository, IRepository<GrcProgram, long> programRepository, IRepository<Project, long> projectsDetailsRepository, IRepository<Employees.Employee, long> employessRepository)
        {
            _dynamicPropertyValueRepository = dynamicPropertyValueRepository;
            _dynamicPropertyManager = dynamicPropertyManager;
            _businessProcessRepository = businessProcessRepository;
            _businessUnitRepository = businessUnitRepository;
            _programRepository = programRepository;
            _projectsDetailsRepository = projectsDetailsRepository;
            _employessRepository = employessRepository;
        }

        public async Task<List<GetDynamicValueDto>> GetDynamicPropertiesByPropertyName(string input)
        {
            var result = new List<GetDynamicValueDto>();
            try
            {
                var allDynamicPropertyList = await _dynamicPropertyManager.GetAllListAsync();
                var dynamicPropertyObject = _dynamicPropertyManager.FirstOrDefault(x => x.PropertyName.ToLower().Trim() == (input).ToLower().Trim());
                if (dynamicPropertyObject != null)
                {
                    var query = await _dynamicPropertyValueRepository.GetAll().Where(l => l.DynamicPropertyId == dynamicPropertyObject.Id).ToListAsync();
                    if (query.Count() != 0)
                    {
                        result = ObjectMapper.Map<List<GetDynamicValueDto>>(query);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return result;
        }

        public string GetNextGeneratedId(string input)
        {
            string result = "";
            switch (input)
            {
                case LockthreatCommonNextParameterConsts.BusinessProcess :
                    var businessProcessObj = _businessProcessRepository.GetAllList().LastOrDefault();
                    if (businessProcessObj != null)
                        result = LockthreatCommonNextParameterConsts.BusinessProcessCode + "" + (businessProcessObj.Id + 1);
                    else
                        result = LockthreatCommonNextParameterConsts.BusinessProcessCode + "1";
                    break;

                case LockthreatCommonNextParameterConsts.BusinessUnit :
                    var businessUnitObj = _businessUnitRepository.GetAllList().LastOrDefault();
                    if (businessUnitObj != null)
                        result = LockthreatCommonNextParameterConsts.BusinessUnitCode + "" + (businessUnitObj.Id + 1);
                    else
                        result = LockthreatCommonNextParameterConsts.BusinessUnitCode + "1";
                    break;

                case LockthreatCommonNextParameterConsts.Employee:
                    var employeeObj = _employessRepository.GetAllList().LastOrDefault();
                    if (employeeObj != null)
                        result = LockthreatCommonNextParameterConsts.EmployeeCode + "" + (employeeObj.Id + 1);
                    else
                        result = LockthreatCommonNextParameterConsts.EmployeeCode + "1";
                    break;

                case LockthreatCommonNextParameterConsts.GRCProgram:
                    var programObj = _programRepository.GetAllList().LastOrDefault();
                    if (programObj != null)
                        result = LockthreatCommonNextParameterConsts.GRCProgramCode + "" + (programObj.Id + 1);
                    else
                        result = LockthreatCommonNextParameterConsts.GRCProgramCode + "1";
                    break;

                case LockthreatCommonNextParameterConsts.ProjectDetail:
                    var projectsDetailObj = _projectsDetailsRepository.GetAllList().LastOrDefault();
                    if (projectsDetailObj != null)
                        result = LockthreatCommonNextParameterConsts.ProjectDetailCode + "" + (projectsDetailObj.Id + 1);
                    else
                        result = LockthreatCommonNextParameterConsts.ProjectDetailCode + "1";
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}
