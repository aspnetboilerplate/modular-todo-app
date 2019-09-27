using System.Reflection;
using Abp.AspNetCore;
using Abp.Modules;
using Abp.Resources.Embedded;
using TodoModule.EntityFrameworkCore;
using TodoModule.Web.Navigation;

namespace TodoModule.Web
{
    [DependsOn(
        typeof(TodoModuleApplicationModule), 
        typeof(TodoModuleEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class TodoModuleWebModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<TodoNavigationProvider>();

            Configuration.EmbeddedResources.Sources.Add(
                new EmbeddedResourceSet(
                    "/Views/",
                    Assembly.GetExecutingAssembly(),
                    "TodoModule.Web.Views"
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}