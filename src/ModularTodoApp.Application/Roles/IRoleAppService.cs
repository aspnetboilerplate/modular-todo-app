using System.Threading.Tasks;
using Abp.Application.Services;
using ModularTodoApp.Roles.Dto;

namespace ModularTodoApp.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
