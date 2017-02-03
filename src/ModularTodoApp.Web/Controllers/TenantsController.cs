using Abp.AspNetCore.Mvc.Authorization;
using ModularTodoApp.Authorization;
using ModularTodoApp.MultiTenancy;
using Microsoft.AspNetCore.Mvc;

namespace ModularTodoApp.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : ModularTodoAppControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}