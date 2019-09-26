using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TodoModule
{
    public class TodoModuleApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TodoModuleApplicationModule).GetAssembly());
        }
    }
}