using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;
using TodoModule.Todos;

namespace TodoModule.Web.Controllers
{
    public class TodosController : AbpController
    {
        private readonly IRepository<TodoItem> _todoItemsRepository;

        public TodosController(IRepository<TodoItem> todoItemsRepository)
        {
            _todoItemsRepository = todoItemsRepository;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _todoItemsRepository.GetAllListAsync();

            return View(tasks);
        }
    }
}
