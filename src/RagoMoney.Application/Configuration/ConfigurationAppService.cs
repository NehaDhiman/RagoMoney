using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RagoMoney.Configuration.Dto;

namespace RagoMoney.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RagoMoneyAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
