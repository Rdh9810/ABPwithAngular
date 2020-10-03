using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace WebWithAngular.Controllers
{
    public abstract class WebWithAngularControllerBase: AbpController
    {
        protected WebWithAngularControllerBase()
        {
            LocalizationSourceName = WebWithAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
