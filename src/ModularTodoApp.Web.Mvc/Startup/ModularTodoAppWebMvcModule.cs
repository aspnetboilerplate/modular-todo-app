using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ModularTodoApp.Configuration;
using TodoModule.Web;

namespace ModularTodoApp.Web.Startup
{
    [DependsOn(typeof(ModularTodoAppWebCoreModule), typeof(TodoModuleWebModule))]
    public class ModularTodoAppWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ModularTodoAppWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ModularTodoAppNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ModularTodoAppWebMvcModule).GetAssembly());
        }
    }
}
