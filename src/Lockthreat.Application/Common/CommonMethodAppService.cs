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

namespace Lockthreat.Common
{
    [AbpAuthorize]
    public class CommonMethodAppService : LockthreatAppServiceBase, ICommonMethodAppService
    {
        private readonly IRepository<DynamicPropertyValue> _dynamicPropertyValueRepository;
        private readonly IRepository<DynamicProperty> _dynamicPropertyManager;

        public CommonMethodAppService(IRepository<DynamicPropertyValue> dynamicPropertyValueRepository, IRepository<DynamicProperty> dynamicPropertyManager)
        {
            _dynamicPropertyValueRepository = dynamicPropertyValueRepository;
            _dynamicPropertyManager = dynamicPropertyManager;
        }

        public async Task<List<GetDynamicValueDto>> GetDynamicPropertiesByPropertyName(string input)
        {
            var result = new List<GetDynamicValueDto>();
            try
            {
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
    }
}
