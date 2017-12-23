using Abp.AspNetCore.Mvc.ViewComponents;

namespace RagoMoney.Web.Views
{
    public abstract class RagoMoneyViewComponent : AbpViewComponent
    {
        protected RagoMoneyViewComponent()
        {
            LocalizationSourceName = RagoMoneyConsts.LocalizationSourceName;
        }
    }
}