using System.Collections.Generic;
using CoreDemo.Roles.Dto;
using CoreDemo.Users.Dto;

namespace CoreDemo.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
