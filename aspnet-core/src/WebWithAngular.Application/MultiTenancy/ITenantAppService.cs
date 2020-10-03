using Abp.Application.Services;
using WebWithAngular.MultiTenancy.Dto;

namespace WebWithAngular.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

