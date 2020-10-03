using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace WebWithAngular.EntityFrameworkCore
{
    public static class WebWithAngularDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<WebWithAngularDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<WebWithAngularDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
