using Abp.Authorization;
using CoreDemo.Authorization.Roles;
using CoreDemo.Authorization.Users;

namespace CoreDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
