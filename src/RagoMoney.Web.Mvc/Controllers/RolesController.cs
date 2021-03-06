using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using RagoMoney.Authorization;
using RagoMoney.Controllers;
using RagoMoney.Roles;
using RagoMoney.Web.Models.Roles;
using Microsoft.AspNetCore.Mvc;

namespace RagoMoney.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Roles)]
    public class RolesController : RagoMoneyControllerBase
    {
        private readonly IRoleAppService _roleAppService;

        public RolesController(IRoleAppService roleAppService)
        {
            _roleAppService = roleAppService;
        }


        public async Task<IActionResult> Index()
        {
            var roles = (await _roleAppService.GetAll(new PagedAndSortedResultRequestDto())).Items;
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new RoleListViewModel
            {
                Roles = roles,
                Permissions = permissions
            };

            return View(model);
        }

        public async Task<ActionResult> EditRoleModal(int roleId)
        {
            var role = await _roleAppService.Get(new EntityDto(roleId));
            var permissions = (await _roleAppService.GetAllPermissions()).Items;
            var model = new EditRoleModalViewModel
            {
                Role = role,
                Permissions = permissions
            };
            return View("_EditRoleModal", model);
        }
    }
}