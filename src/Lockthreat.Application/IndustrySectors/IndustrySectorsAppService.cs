using Abp.Domain.Repositories;
using Abp.DynamicEntityProperties;
using Lockthreat.IndustrySectors.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lockthreat.IndustrySectors
{


    public class IndustrySectorsAppService : IIndustrySectorAppService
    {
        private readonly IRepository<DynamicPropertyValue> _DynamicParameterValueRepository;
        private readonly IRepository<DynamicProperty> _dynamicParameterManager;

        public IndustrySectorsAppService(
          IRepository<DynamicPropertyValue> DynamicParameterValueRepository, 
          IRepository<DynamicProperty> dynamicParameterManager
          )
        {
            _DynamicParameterValueRepository = DynamicParameterValueRepository;
            _dynamicParameterManager = dynamicParameterManager;
        }
        public async Task<List<IndustrySectorDto>> GetAll()
        {
            var getIndustrySector = new List<IndustrySectorDto>();
            try
            {
                var getcheckId = _dynamicParameterManager.FirstOrDefault(x => x.PropertyName.ToLower().Trim() == "industry sector");
                if (getcheckId != null)
                {
                     getIndustrySector = await _DynamicParameterValueRepository.GetAll()
                        .Where(l => l.DynamicPropertyId == getcheckId.Id)
                         .Select(x => new IndustrySectorDto()
                         {
                             Id = x.Id,
                             Name = x.Value,
                         }).ToListAsync();

                    return getIndustrySector;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            return getIndustrySector;
        }
    }
}
