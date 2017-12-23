using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RagoMoney.Authorization;

namespace RagoMoney
{
    [DependsOn(
        typeof(RagoMoneyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RagoMoneyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RagoMoneyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RagoMoneyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}
