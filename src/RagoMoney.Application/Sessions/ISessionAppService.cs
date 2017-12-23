using System.Threading.Tasks;
using Abp.Application.Services;
using RagoMoney.Sessions.Dto;

namespace RagoMoney.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
