using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Lockthreat.AssetInformations.Dto;
using Lockthreat.Auditing.Dto;
using Lockthreat.Dto;

namespace Lockthreat.AssetInformations
{
    public interface IAssetInformationAppservice : IApplicationService
    {
        Task RemoveBusinessService(long id);
        Task RemoveBusinessProcess(long id);
        Task RemoveItService(long id);
        Task RemoveAssetInformation(long assetId);
        Task<PagedResultDto<GetAssetInformationListDto>> GetAllAssetinformationList(AssetInformationInput input);
        Task CreateOrUpdateAssetinformation(GetAssetInformationDto input);
        Task<GetAssetInformationDto> GetAllAssetInformationInfo(long? assetId);
    }
}