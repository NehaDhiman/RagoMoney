using Abp.Application.Services;
using Abp.Application.Services.Dto;
using RagoMoney.MultiTenancy.Dto;

namespace RagoMoney.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
