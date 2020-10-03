using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebWithAngular.EntityFrameworkCore;
using WebWithAngular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace WebWithAngular.Web.Tests
{
    [DependsOn(
        typeof(WebWithAngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class WebWithAngularWebTestModule : AbpModule
    {
        public WebWithAngularWebTestModule(WebWithAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(WebWithAngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(WebWithAngularWebMvcModule).Assembly);
        }
    }
}