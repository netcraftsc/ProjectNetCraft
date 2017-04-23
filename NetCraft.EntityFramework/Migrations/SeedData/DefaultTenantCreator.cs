using System.Linq;
using NetCraft.EntityFramework;
using NetCraft.MultiTenancy;

namespace NetCraft.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly NetCraftDbContext _context;

        public DefaultTenantCreator(NetCraftDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
