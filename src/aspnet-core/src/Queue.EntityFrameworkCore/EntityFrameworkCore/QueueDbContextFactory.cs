using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Queue.Configuration;
using Queue.Web;

namespace Queue.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class QueueDbContextFactory : IDesignTimeDbContextFactory<QueueDbContext>
    {
        public QueueDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<QueueDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            QueueDbContextConfigurer.Configure(builder, configuration.GetConnectionString(QueueConsts.ConnectionStringName));

            return new QueueDbContext(builder.Options);
        }
    }
}
