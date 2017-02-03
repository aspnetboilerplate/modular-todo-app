using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;

namespace ModularTodoApp.EntityFramework
{
    [DependsOn(
        typeof(ModularTodoAppCoreModule), 
        typeof(AbpZeroEntityFrameworkModule))]
    public class ModularTodoAppEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ModularTodoAppDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}