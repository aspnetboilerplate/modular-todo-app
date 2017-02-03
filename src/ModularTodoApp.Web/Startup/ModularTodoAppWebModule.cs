using System.Reflection;
using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using ModularTodoApp.Configuration;
using ModularTodoApp.EntityFramework;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Zero.Configuration;
using TodoModule.Web;

namespace ModularTodoApp.Web.Startup
{
    [DependsOn(
        typeof(ModularTodoAppApplicationModule), 
        typeof(ModularTodoAppEntityFrameworkModule), 
        typeof(AbpAspNetCoreModule),
        typeof(TodoWebModule))]
    public class ModularTodoAppWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ModularTodoAppWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ModularTodoAppConsts.ConnectionStringName);

            //Use database for language management
            Configuration.Modules.Zero().LanguageManagement.EnableDbLocalization();

            Configuration.Navigation.Providers.Add<ModularTodoAppNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ModularTodoAppApplicationModule).Assembly
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}