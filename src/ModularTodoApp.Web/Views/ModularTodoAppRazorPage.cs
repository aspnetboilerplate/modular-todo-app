using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace ModularTodoApp.Web.Views
{
    public abstract class ModularTodoAppRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ModularTodoAppRazorPage()
        {
            LocalizationSourceName = ModularTodoAppConsts.LocalizationSourceName;
        }
    }
}
