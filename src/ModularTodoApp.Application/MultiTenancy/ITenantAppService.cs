using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ModularTodoApp.MultiTenancy.Dto;

namespace ModularTodoApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

