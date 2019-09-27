using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ModularTodoApp.Controllers;

namespace ModularTodoApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ModularTodoAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
