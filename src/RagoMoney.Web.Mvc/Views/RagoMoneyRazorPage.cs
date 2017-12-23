using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace RagoMoney.Web.Views
{
    public abstract class RagoMoneyRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RagoMoneyRazorPage()
        {
            LocalizationSourceName = RagoMoneyConsts.LocalizationSourceName;
        }
    }
}
