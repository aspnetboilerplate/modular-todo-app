using System.Reflection;
using Abp.Modules;

namespace TodoModule
{
    public class TodoApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
