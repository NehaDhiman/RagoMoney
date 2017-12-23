using Abp.Modules;
using Abp.Reflection.Extensions;
using RagoMoney.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace RagoMoney.Web.Startup
{
    [DependsOn(typeof(RagoMoneyWebCoreModule))]
    public class RagoMoneyWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RagoMoneyWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<RagoMoneyNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RagoMoneyWebMvcModule).GetAssembly());
        }
    }
}