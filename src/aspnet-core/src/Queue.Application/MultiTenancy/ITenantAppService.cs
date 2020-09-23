using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Queue.MultiTenancy.Dto;

namespace Queue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

