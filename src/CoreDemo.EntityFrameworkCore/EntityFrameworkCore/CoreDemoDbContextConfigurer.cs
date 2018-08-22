using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreDemo.EntityFrameworkCore
{
    public static class CoreDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CoreDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CoreDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
