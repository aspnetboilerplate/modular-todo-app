using Abp.Application.Services;
using TodoModule.Todos.Dto;

namespace TodoModule.Todos
{
    public interface ITodoAppService : IAsyncCrudAppService<TodoItemDto>
    {
        
    }
}
