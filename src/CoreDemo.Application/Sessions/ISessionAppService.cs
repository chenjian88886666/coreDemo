using System.Threading.Tasks;
using Abp.Application.Services;
using CoreDemo.Sessions.Dto;

namespace CoreDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
