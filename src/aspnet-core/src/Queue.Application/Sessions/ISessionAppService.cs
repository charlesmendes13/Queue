using System.Threading.Tasks;
using Abp.Application.Services;
using Queue.Sessions.Dto;

namespace Queue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
