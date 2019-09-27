using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
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
            var thisAssembly = typeof(ModularTodoAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
