using Abp.Authorization;
using RagoMoney.Authorization.Roles;
using RagoMoney.Authorization.Users;

namespace RagoMoney.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
