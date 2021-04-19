using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using PagedList.Core;
using zepllin.Models;
using zepllin.Interfaces;
using zepllin.Extra;
namespace zepllin.Areas.AdminUser.Controllers
{
    [Area("AdminUser")]
    [Authorize(Roles = "Admin")]
    public class AdminUsersController : Controller
    {
        private readonly UserManager<CreateUsers> users;

        private readonly RoleManager<IdentityRole> rolemanager;

        private readonly INormalUserRole normaluserrole;

        private readonly IDatabaseRepository<UserImages> databaseuserfolderdel;

        private readonly IUserImages usimages;
        public AdminUsersController(UserManager<CreateUsers> users,
            RoleManager<IdentityRole> rolemanager,
            INormalUserRole normaluserrole,
            IUserImages usimages,
            IDatabaseRepository<UserImages> databaseuserfolderdel)
        {
            this.users = users;
            this.rolemanager = rolemanager;
            this.normaluserrole = normaluserrole;
            this.usimages = usimages;
            this.databaseuserfolderdel = databaseuserfolderdel;
        }
        #region
        public ActionResult Index(int page = 3, int pagesize = 5)
        {
            PagedList<CreateUsers> listresult = new PagedList<CreateUsers>(users.Users.ToList().AsQueryable().AsEnumerable(), page, pagesize);
            return View(listresult);    
        }
        #endregion
        #region
        [HttpPost]
        public ActionResult Index(string searchterm,int page = 1,int pagesize = 20)
        {
            if (!string.IsNullOrEmpty(searchterm))
            {
                var localuser = users.Users.ToList();
                ViewBag.searchterm = searchterm;
                var userresult = localuser.Where(xuser => xuser.UserName.Contains(searchterm));
                PagedList<CreateUsers> searchlist = new PagedList<CreateUsers>(userresult.ToList().AsQueryable().AsEnumerable(), page, pagesize);
                return View(searchlist);
            }
            return RedirectToAction("Index", "Admin", new { area = "Admin" });
        }
        #endregion
        #region
        [HttpPost]
        public async Task<ActionResult> UserDelete(string id)
        {
            var user = await users.FindByIdAsync(id);
            usimages.UserName = user.UserName;
            if (user != null)
             {
                foreach (var item in databaseuserfolderdel.GetAllList().Where(c => c.UserName == usimages.UserName).Select(p => new { UserName = p.UserName, UserNormalId = p.UserNormalId }).ToList())
                {
                    string path = $"{RootFolder.RootFolderWithSubFolderAndSlash}{item.UserNormalId}";
                    string fullpath = Path.GetFullPath(path);
                    if (Directory.Exists(fullpath))
                    {
                        Directory.Delete(fullpath, true);
                    }               
                    databaseuserfolderdel.SpDeleteFromFolderAndDatabase(item.UserNormalId);
                    await users.DeleteAsync(user);
                }
            }
            else
             {
                 return Content("Hata Oluştu");
             }
            return Content(string.Empty);
        }
        #endregion
        #region
        [HttpPost]
        public async Task<ActionResult> AddToRole(string rolename)
        {
            var res = await rolemanager.CreateAsync(new IdentityRole(rolename));
            if (res.Succeeded)
            {
                return Content("Rol Eklendi");
            }
            return Content(string.Empty);
        }
        #endregion
    }
}
