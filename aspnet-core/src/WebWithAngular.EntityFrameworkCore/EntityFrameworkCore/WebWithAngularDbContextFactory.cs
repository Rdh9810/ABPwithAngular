using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using WebWithAngular.Configuration;
using WebWithAngular.Web;

namespace WebWithAngular.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class WebWithAngularDbContextFactory : IDesignTimeDbContextFactory<WebWithAngularDbContext>
    {
        public WebWithAngularDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<WebWithAngularDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            WebWithAngularDbContextConfigurer.Configure(builder, configuration.GetConnectionString(WebWithAngularConsts.ConnectionStringName));

            return new WebWithAngularDbContext(builder.Options);
        }
    }
}
