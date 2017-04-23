using System.Threading.Tasks;
using Abp.Application.Services;
using NetCraft.Roles.Dto;

namespace NetCraft.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
