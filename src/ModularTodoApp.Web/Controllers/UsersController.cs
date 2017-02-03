using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using ModularTodoApp.Authorization;
using ModularTodoApp.Users;
using Microsoft.AspNetCore.Mvc;

namespace ModularTodoApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : ModularTodoAppControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _userAppService.GetUsers();
            return View(output);
        }
    }
}