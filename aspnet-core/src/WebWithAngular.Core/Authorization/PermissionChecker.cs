using Abp.Authorization;
using WebWithAngular.Authorization.Roles;
using WebWithAngular.Authorization.Users;

namespace WebWithAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
