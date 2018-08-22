using System.Threading.Tasks;
using Abp.Application.Services;
using CoreDemo.Authorization.Accounts.Dto;

namespace CoreDemo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
