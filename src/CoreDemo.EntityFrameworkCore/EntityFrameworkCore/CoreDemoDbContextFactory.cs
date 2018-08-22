using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreDemo.Configuration;
using CoreDemo.Web;

namespace CoreDemo.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreDemoDbContextFactory : IDesignTimeDbContextFactory<CoreDemoDbContext>
    {
        public CoreDemoDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreDemoDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CoreDemoDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreDemoConsts.ConnectionStringName));

            return new CoreDemoDbContext(builder.Options);
        }
    }
}
