using Abp.Modules;
using Abp.Reflection.Extensions;

namespace TodoModule
{
    public class TodoModuleCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TodoModuleCoreModule).GetAssembly());
        }
    }
}