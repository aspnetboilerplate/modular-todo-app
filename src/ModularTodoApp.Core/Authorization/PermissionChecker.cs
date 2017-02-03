using Abp.Authorization;
using ModularTodoApp.Authorization.Roles;
using ModularTodoApp.MultiTenancy;
using ModularTodoApp.Users;

namespace ModularTodoApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
