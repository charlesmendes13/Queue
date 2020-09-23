using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Queue.EntityFrameworkCore
{
    public static class QueueDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<QueueDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<QueueDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
