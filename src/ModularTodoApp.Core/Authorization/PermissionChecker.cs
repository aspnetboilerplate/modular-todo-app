using Abp.Authorization;
using ModularTodoApp.Authorization.Roles;
using ModularTodoApp.Authorization.Users;

namespace ModularTodoApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
