using System.Collections.Generic;
using RagoMoney.Roles.Dto;
using RagoMoney.Users.Dto;

namespace RagoMoney.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}