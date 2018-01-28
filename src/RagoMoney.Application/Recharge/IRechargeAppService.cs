using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RagoMoney.Recharge.Dto;

namespace RagoMoney.Recharge
{
    public interface IRechargeAppService : IAsyncCrudAppService<RechargeDto, long, PagedResultRequestDto, RechargeDto>
    {

    }
}
