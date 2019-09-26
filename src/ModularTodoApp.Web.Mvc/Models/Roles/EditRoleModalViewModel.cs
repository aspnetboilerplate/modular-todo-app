using Abp.AutoMapper;
using ModularTodoApp.Roles.Dto;
using ModularTodoApp.Web.Models.Common;

namespace ModularTodoApp.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
