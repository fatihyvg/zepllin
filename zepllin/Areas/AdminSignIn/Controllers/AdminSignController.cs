using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using zepllin.Interfaces;
using zepllin.Models;

namespace zepllin.Areas.AdminSignIn.Controllers
{
    [Area("AdminSignIn")]
    public class AdminSignController : Controller
    {

        private readonly SignInManager<CreateUsers> loginandresult;

        private readonly IAdminLogin adminlogin;
        public AdminSignController(SignInManager<CreateUsers> loginandresult, IAdminLogin adminlogin)
        {
            this.adminlogin = adminlogin;
            this.loginandresult = loginandresult;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Index(AdminLogin login)
        {
            string returnUrl = Url.Action("Index", "Admin", new { area = "Admin" });
            if (ModelState.IsValid)
            {
                adminlogin.UserName = login.UserName;
                adminlogin.UserPassword = login.UserPassword;
                HttpContext.Session.SetString("adminusername", adminlogin.UserName);
                var logresult = await loginandresult.PasswordSignInAsync(adminlogin.UserName, adminlogin.UserPassword, false, false);

                if (logresult.Succeeded)
                {
                    if (Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                }
                ModelState.AddModelError(string.Empty, "Kullanıcı Adı Veya Şifre Hatalı Veya Giriş Yetkiniz Yok.");
            }
            return View((AdminLogin)adminlogin);
        }
    }
}
