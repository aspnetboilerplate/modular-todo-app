using System.Data.Entity;
using System.Reflection;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using ModularTodoApp.Configuration;
using ModularTodoApp.EntityFramework;

namespace ModularTodoApp.Migrator
{
    [DependsOn(typeof(ModularTodoAppEntityFrameworkModule))]
    public class ModularTodoAppMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ModularTodoAppMigratorModule()
        {
            _appConfiguration = AppConfigurations.Get(
                typeof(ModularTodoAppMigratorModule).Assembly.GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Database.SetInitializer<ModularTodoAppDbContext>(null);

            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ModularTodoAppConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}