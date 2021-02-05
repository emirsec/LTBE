using Abp.Domain.Repositories;
using Abp.DynamicEntityProperties;
using Lockthreat.Common;
using Lockthreat.IndustrySectors.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Lockthreat.IndustrySectors
{


    public class IndustrySectorsAppService : LockthreatAppServiceBase, IIndustrySectorAppService
    {
        private readonly ICommonMethodAppService _commonMethodAppService;

        public IndustrySectorsAppService(ICommonMethodAppService commonMethodAppService)
        {
            _commonMethodAppService = commonMethodAppService;
        }

        public async Task<List<IndustrySectorDto>> GetAll()
        {
            var getIndustrySector = new List<IndustrySectorDto>();
            var query = await _commonMethodAppService.GetDynamicPropertiesByPropertyName("industry sector");
            getIndustrySector = ObjectMapper.Map<List<IndustrySectorDto>>(query);
            return getIndustrySector;
        }
    }
}
