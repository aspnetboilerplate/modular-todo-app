using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace TodoModule.Web.Controllers
{
    public class TodosController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
