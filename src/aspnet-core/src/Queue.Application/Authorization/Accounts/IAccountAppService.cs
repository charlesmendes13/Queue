using System.Threading.Tasks;
using Abp.Application.Services;
using Queue.Authorization.Accounts.Dto;

namespace Queue.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
