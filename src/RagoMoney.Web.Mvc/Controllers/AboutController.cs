using Abp.AspNetCore.Mvc.Authorization;
using RagoMoney.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace RagoMoney.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : RagoMoneyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}