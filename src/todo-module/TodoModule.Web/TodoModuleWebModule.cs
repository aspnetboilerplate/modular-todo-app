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

            //Must call app.UseEmbeddedFiles() at main application Configure!
            Configuration.EmbeddedResources.Sources.Add(
                new EmbeddedResourceSet(
                    "/Resources/",
                    Assembly.GetExecutingAssembly(),
                    "TodoModule.Web.Resources"
                    )
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}