using System.Collections.Generic;
using CoreDemo.Roles.Dto;

namespace CoreDemo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}