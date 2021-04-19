using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Manager")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roles;

        private readonly SignInManager<CreateUsers> loginandresult;

        private readonly IDatabaseRepository<UserImages> usim;
        public AdminController(SignInManager<CreateUsers> loginandresult,RoleManager<IdentityRole> roles, IDatabaseRepository<UserImages> usim)
        {
            this.roles = roles;
            this.loginandresult = loginandresult;
            this.usim = usim;
        }
        public ActionResult Index()
        {
            return View();
        }
        /*TODO Admin Tarafı*/
        #region
        [HttpPost]
        public async Task<ActionResult> Index(string rolename)
        {
            var res = await roles.CreateAsync(new IdentityRole(rolename));
            if(res.Succeeded)
            {
                return View(res);
            }
            return View(res);
        }
        /*TODO Admin Çıkış*/
        public async Task<ActionResult> AdminSignOut()
        {
            await loginandresult.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "AdminSign", new { area = "AdminSignIn" });
        }
        /*TODO Admin arama tarafı*/
        [HttpGet]
        public JsonResult AdminPhotoSearchMove(string term)
        {
            List<UserImages> admimage = new List<UserImages>();
            foreach (var item in usim.SpSearch(term).Where(p => p.ImageApprove == 0 || p.ImageApprove == 1).Select(r => new
            {
                ImageId = r.ImageId,
                ImageSrc = r.ImageSrc,
                ImageTitle = r.ImageTitle,
                ImageWithoutSeoTitle = r.ImageWithoutSeoTitle
            }).ToList())
            {
                admimage.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageSrc = item.ImageSrc,
                    ImageTitle = item.ImageTitle,
                    ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                });
            }
            return Json(admimage.AsEnumerable());
        }
        #endregion
    }
}
