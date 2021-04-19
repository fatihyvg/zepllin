using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using zepllin.Models;
namespace zepllin.Interfaces
{
    public interface INormalUserRole
    {
        string UserId
        {
            get;
            set;
        }
        string RoleId
        {
            get;
            set;
        }
        string UserName
        {
            get;
            set;
        }
        string RoleName
        {
            get;
            set;
        }
        bool IsSelected
        {
            get;
            set;
        }
        List<NormalUser> Users
        {
            get;
            set;
        }
        List<IdentityRole> RoleList
        {
            get;
            set;
        }
        List<string> RoleListNames
        {
            get;
            set;
        }
    }
}
