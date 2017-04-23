using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using NetCraft.EntityFramework;

namespace NetCraft.Migrator
{
    [DependsOn(typeof(NetCraftDataModule))]
    public class NetCraftMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<NetCraftDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}