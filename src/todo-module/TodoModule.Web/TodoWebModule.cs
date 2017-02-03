using System.Reflection;
using Abp.AspNetCore;
using Abp.Modules;
using Abp.Resources.Embedded;
using TodoModule.Web.Navigation;

namespace TodoModule.Web
{
    [DependsOn(typeof(AbpAspNetCoreModule))]
    public class TodoWebModule : AbpModule
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
