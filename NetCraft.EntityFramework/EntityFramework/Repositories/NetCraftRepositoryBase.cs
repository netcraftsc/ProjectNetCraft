using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace NetCraft.EntityFramework.Repositories
{
    public abstract class NetCraftRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<NetCraftDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected NetCraftRepositoryBase(IDbContextProvider<NetCraftDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class NetCraftRepositoryBase<TEntity> : NetCraftRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected NetCraftRepositoryBase(IDbContextProvider<NetCraftDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
