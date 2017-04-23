using Abp.Authorization;
using NetCraft.Authorization.Roles;
using NetCraft.MultiTenancy;
using NetCraft.Users;

namespace NetCraft.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
