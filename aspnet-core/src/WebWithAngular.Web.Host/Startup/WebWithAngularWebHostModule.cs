using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebWithAngular.Configuration;

namespace WebWithAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(WebWithAngularWebCoreModule))]
    public class WebWithAngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public WebWithAngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebWithAngularWebHostModule).GetAssembly());
        }
    }
}
