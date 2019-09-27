using System.Collections.Generic;
using ModularTodoApp.Roles.Dto;
using ModularTodoApp.Users.Dto;

namespace ModularTodoApp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
