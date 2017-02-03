using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;

namespace TodoModule.EntityFramework
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(TodoCoreModule))]
    public class TodoEntityFrameworkModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<TodoDbContext>());
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
