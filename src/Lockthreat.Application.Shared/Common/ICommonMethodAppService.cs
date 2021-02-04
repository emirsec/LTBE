using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Lockthreat.Common.Dto;
using Lockthreat.DynamicEntityProperties.Dto;
using Lockthreat.Editions.Dto;

namespace Lockthreat.Common
{
    public interface ICommonMethodAppService : IApplicationService
    {
        Task<List<GetDynamicValueDto>> GetDynamicPropertiesByPropertyName(string input);
        string GetNextGeneratedId(string input);
    }
}