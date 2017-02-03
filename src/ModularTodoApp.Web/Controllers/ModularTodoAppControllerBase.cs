using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace ModularTodoApp.Web.Controllers
{
    public abstract class ModularTodoAppControllerBase: AbpController
    {
        protected ModularTodoAppControllerBase()
        {
            LocalizationSourceName = ModularTodoAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}