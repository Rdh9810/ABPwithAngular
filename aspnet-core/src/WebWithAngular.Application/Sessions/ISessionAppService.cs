using System.Threading.Tasks;
using Abp.Application.Services;
using WebWithAngular.Sessions.Dto;

namespace WebWithAngular.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
