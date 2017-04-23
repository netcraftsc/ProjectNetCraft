using NetCraft.EntityFramework;
using EntityFramework.DynamicFilters;

namespace NetCraft.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly NetCraftDbContext _context;

        public InitialHostDbBuilder(NetCraftDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
