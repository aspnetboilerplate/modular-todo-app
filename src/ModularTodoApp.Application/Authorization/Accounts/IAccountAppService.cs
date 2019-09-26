using System.Threading.Tasks;
using Abp.Application.Services;
using ModularTodoApp.Authorization.Accounts.Dto;

namespace ModularTodoApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
