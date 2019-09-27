using System.Collections.Generic;
using ModularTodoApp.Roles.Dto;

namespace ModularTodoApp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}