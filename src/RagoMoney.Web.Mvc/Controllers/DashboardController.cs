using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using RagoMoney.Controllers;

namespace RagoMoney.Web.Mvc.Controllers
{
    [AbpMvcAuthorize]
    public class DashboardController : RagoMoneyControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}