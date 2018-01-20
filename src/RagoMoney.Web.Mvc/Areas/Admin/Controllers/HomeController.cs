using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RagoMoney.Controllers;

namespace RagoMoney.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AbpMvcAuthorize]
    public class HomeController : RagoMoneyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}