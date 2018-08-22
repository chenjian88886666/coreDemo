using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CoreDemo.MultiTenancy.Dto;

namespace CoreDemo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
