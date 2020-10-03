using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using WebWithAngular.Authorization;

namespace WebWithAngular
{
    [DependsOn(
        typeof(WebWithAngularCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class WebWithAngularApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<WebWithAngularAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(WebWithAngularApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
