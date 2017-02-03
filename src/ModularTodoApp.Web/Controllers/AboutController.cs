using Microsoft.AspNetCore.Mvc;

namespace ModularTodoApp.Web.Controllers
{
    public class AboutController : ModularTodoAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}