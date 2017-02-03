using System;
using Abp.Modules;
using Abp.MultiTenancy;
using Abp.TestBase;
using Abp.Zero.Configuration;
using ModularTodoApp.EntityFramework;
using Castle.MicroKernel.Registration;
using NSubstitute;

namespace ModularTodoApp.Tests
{
    [DependsOn(
        typeof(ModularTodoAppApplicationModule),
        typeof(ModularTodoAppEntityFrameworkModule),
        typeof(AbpTestBaseModule)
        )]
    public class ModularTodoAppTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.Timeout = TimeSpan.FromMinutes(30);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            RegisterFakeService<IAbpZeroDbMigrator>();
        }

        private void RegisterFakeService<TService>() where TService : class
        {
            IocManager.IocContainer.Register(
                Component.For<TService>()
                    .UsingFactoryMethod(() => Substitute.For<TService>())
                    .LifestyleSingleton()
            );
        }
    }
}