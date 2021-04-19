using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using zepllin.Interfaces;
namespace zepllin.Models
{
    #region
    public class NormalUserRole : INormalUserRole
    {
        public string UserId
        {
            get;
            set;
        }
        public string RoleId
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string RoleName
        {
            get;
            set;
        }
        public bool IsSelected
        {
            get;
            set;
        }
        public List<NormalUser> Users
        {
            get;
            set;
        }
        public List<IdentityRole> RoleList
        {
            get;
            set;
        }
        public List<string> RoleListNames
        {
            get;
            set;
        }
    }
    #endregion
}
