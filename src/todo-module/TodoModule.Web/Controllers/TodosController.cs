using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using TodoModule.Todos;

namespace TodoModule.Web.Controllers
{
    public class TodosController : AbpController
    {
        private readonly ITodoAppService _todoAppService;

        public TodosController(ITodoAppService todoAppService)
        {
            _todoAppService = todoAppService;
        }

        public async Task<IActionResult> Index()
        {
            var output = await _todoAppService.GetAll(
                new PagedAndSortedResultRequestDto()
            );

            return View(output);
        }
    }
}
