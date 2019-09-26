using Abp.AspNetCore.Mvc.ViewComponents;

namespace ModularTodoApp.Web.Views
{
    public abstract class ModularTodoAppViewComponent : AbpViewComponent
    {
        protected ModularTodoAppViewComponent()
        {
            LocalizationSourceName = ModularTodoAppConsts.LocalizationSourceName;
        }
    }
}
