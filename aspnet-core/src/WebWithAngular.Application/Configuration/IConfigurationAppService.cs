using System.Threading.Tasks;
using WebWithAngular.Configuration.Dto;

namespace WebWithAngular.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
