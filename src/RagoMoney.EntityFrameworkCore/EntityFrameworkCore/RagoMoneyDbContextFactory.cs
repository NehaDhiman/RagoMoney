using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RagoMoney.Configuration;
using RagoMoney.Web;

namespace RagoMoney.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RagoMoneyDbContextFactory : IDesignTimeDbContextFactory<RagoMoneyDbContext>
    {
        public RagoMoneyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RagoMoneyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RagoMoneyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RagoMoneyConsts.ConnectionStringName));

            return new RagoMoneyDbContext(builder.Options);
        }
    }
}
