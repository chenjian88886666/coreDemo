using System.Collections.Generic;
using CoreDemo.Roles.Dto;

namespace CoreDemo.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
