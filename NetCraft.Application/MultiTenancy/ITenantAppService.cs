using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCraft.MultiTenancy.Dto;

namespace NetCraft.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
