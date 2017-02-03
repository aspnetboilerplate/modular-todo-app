using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using ModularTodoApp.MultiTenancy;
using ModularTodoApp.Users;
using Microsoft.AspNet.Identity;
using Abp.Runtime.Session;
using Abp.IdentityFramework;

namespace ModularTodoApp
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ModularTodoAppAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected ModularTodoAppAppServiceBase()
        {
            LocalizationSourceName = ModularTodoAppConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}