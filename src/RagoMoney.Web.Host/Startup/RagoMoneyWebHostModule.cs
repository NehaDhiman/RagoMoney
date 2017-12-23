using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RagoMoney.Configuration;

namespace RagoMoney.Web.Host.Startup
{
    [DependsOn(
       typeof(RagoMoneyWebCoreModule))]
    public class RagoMoneyWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RagoMoneyWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RagoMoneyWebHostModule).GetAssembly());
        }
    }
}
