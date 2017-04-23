using System.Data.Common;
using Abp.Zero.EntityFramework;
using NetCraft.Authorization.Roles;
using NetCraft.MultiTenancy;
using NetCraft.Users;

namespace NetCraft.EntityFramework
{
    public class NetCraftDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public NetCraftDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in NetCraftDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of NetCraftDbContext since ABP automatically handles it.
         */
        public NetCraftDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public NetCraftDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public NetCraftDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
