using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RagoMoney.Controllers;
using RagoMoney.Web.Areas.Retailer.Models;

namespace RagoMoney.Web.Mvc.Areas.Retailer.Controllers
{
    [Area("Retailer")]
    [AbpMvcAuthorize]
    public class TransactionController : RagoMoneyControllerBase
    {
       
        [HttpGet]
        public ActionResult MoneyTransfer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoneyTransfer(MoneyTransfer money)
        {
            return View();
        }
    }
}