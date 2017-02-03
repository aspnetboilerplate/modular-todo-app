using System.Threading.Tasks;
using Abp.Application.Services;
using ModularTodoApp.Sessions.Dto;

namespace ModularTodoApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
