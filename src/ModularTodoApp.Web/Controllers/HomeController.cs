using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ModularTodoApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ModularTodoAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}