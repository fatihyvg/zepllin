using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using zepllin.Models;
using zepllin.Interfaces;
namespace zepllin.Areas.AdminRoleList.Controllers
{
    [Area("AdminRoleList")]
    [Authorize(Roles = "Admin")]
    public class AdminRolesListController : Controller
    {
        private readonly RoleManager<IdentityRole> rolemanager;

        private readonly UserManager<CreateUsers> users;

        private readonly INormalUserRole normaluserrole;
        public AdminRolesListController(RoleManager<IdentityRole> rolemanager, UserManager<CreateUsers> users, INormalUserRole normaluserrole)
        {
            this.rolemanager = rolemanager;
            this.normaluserrole = normaluserrole;
            this.users = users;
        }
        #region
        /*TODO Rolleri Getir*/
        public async Task<ActionResult> Index(string Id)
        {
            var user = await users.FindByIdAsync(Id);
            ViewBag.id = user.Id;
            normaluserrole.RoleList = rolemanager.Roles.ToList();
            normaluserrole.RoleListNames = await users.GetRolesAsync(user) as List<string>;
            List<NormalUserRole> resultroles = new List<NormalUserRole>();
            normaluserrole.RoleList.ForEach(role => resultroles.Add(new NormalUserRole
            {
                IsSelected = normaluserrole.RoleListNames.Contains(role.Name),
                RoleId = role.Id,
                RoleName = role.Name
            }));
            return View(resultroles);
        }
        #endregion
        #region
        /*TODO Rol Onay*/
        [HttpPost]
        public async Task<ActionResult> RoleApply(List<NormalUserRole> rolelist,string Id)
        {
            var user = await users.FindByIdAsync(Id);
            var roles = await users.GetRolesAsync(user);
            var result = await users.RemoveFromRolesAsync(user, roles);
            result = await users.AddToRolesAsync(user, rolelist.Where(x => x.IsSelected).Select(y => y.RoleName));
            return Content(string.Empty);
        }
        #endregion
    }
}
