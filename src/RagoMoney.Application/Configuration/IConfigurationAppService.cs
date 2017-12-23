using System.Threading.Tasks;
using RagoMoney.Configuration.Dto;

namespace RagoMoney.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
