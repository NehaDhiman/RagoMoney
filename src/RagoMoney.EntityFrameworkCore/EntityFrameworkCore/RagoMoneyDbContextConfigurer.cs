using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RagoMoney.EntityFrameworkCore
{
    public static class RagoMoneyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RagoMoneyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RagoMoneyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
