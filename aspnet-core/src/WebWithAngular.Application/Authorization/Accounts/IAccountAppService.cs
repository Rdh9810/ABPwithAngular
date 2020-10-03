using System.Threading.Tasks;
using Abp.Application.Services;
using WebWithAngular.Authorization.Accounts.Dto;

namespace WebWithAngular.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
