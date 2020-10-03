using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using WebWithAngular.Configuration.Dto;

namespace WebWithAngular.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : WebWithAngularAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
