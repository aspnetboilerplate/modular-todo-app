using System.Reflection;
using Abp.Modules;
using Abp.Timing;
using Abp.Zero;
using ModularTodoApp.Localization;
using Abp.Zero.Configuration;
using ModularTodoApp.MultiTenancy;
using ModularTodoApp.Authorization.Roles;
using ModularTodoApp.Users;
using ModularTodoApp.Timing;

namespace ModularTodoApp
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class ModularTodoAppCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            ModularTodoAppLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = true;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}