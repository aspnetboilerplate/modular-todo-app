using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ModularTodoApp.EntityFramework.Repositories
{
    public abstract class ModularTodoAppRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ModularTodoAppDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ModularTodoAppRepositoryBase(IDbContextProvider<ModularTodoAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ModularTodoAppRepositoryBase<TEntity> : ModularTodoAppRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ModularTodoAppRepositoryBase(IDbContextProvider<ModularTodoAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
