using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Queue.Roles.Dto;
using Queue.Users.Dto;

namespace Queue.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
