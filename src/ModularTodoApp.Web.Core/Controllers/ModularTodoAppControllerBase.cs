using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ModularTodoApp.Controllers
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
