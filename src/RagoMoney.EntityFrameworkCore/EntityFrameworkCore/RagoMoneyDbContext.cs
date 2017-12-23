using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RagoMoney.Authorization.Roles;
using RagoMoney.Authorization.Users;
using RagoMoney.MultiTenancy;

namespace RagoMoney.EntityFrameworkCore
{
    public class RagoMoneyDbContext : AbpZeroDbContext<Tenant, Role, User, RagoMoneyDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public RagoMoneyDbContext(DbContextOptions<RagoMoneyDbContext> options)
            : base(options)
        {
        }
    }
}
