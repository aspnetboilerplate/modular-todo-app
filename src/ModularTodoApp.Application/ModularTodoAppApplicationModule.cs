using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using ModularTodoApp.Authorization;

namespace ModularTodoApp
{
    [DependsOn(
        typeof(ModularTodoAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ModularTodoAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ModularTodoAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}