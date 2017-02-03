using System.Data.Entity;
using System.Linq;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using TodoModule.Todos.Dto;

namespace TodoModule.Todos
{
    public class TodoAppService : AsyncCrudAppService<TodoItem, TodoItemDto>, ITodoAppService
    {
        public TodoAppService(IRepository<TodoItem, int> repository) 
            : base(repository)
        {
        }

        protected override IQueryable<TodoItem> CreateFilteredQuery(PagedAndSortedResultRequestDto input)
        {
            return base.CreateFilteredQuery(input).Include(t => t.AssignedUser);
        }
    }
}