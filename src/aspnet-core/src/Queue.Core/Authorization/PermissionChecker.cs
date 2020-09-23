using Abp.Authorization;
using Queue.Authorization.Roles;
using Queue.Authorization.Users;

namespace Queue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
