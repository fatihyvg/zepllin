using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [AllowAnonymous]
    public class RegistrationController : Controller
    {
        private readonly INormalUser normuser;

        private readonly UserManager<CreateUsers> usmanager;
        public RegistrationController(UserManager<CreateUsers> usmanager, INormalUser normuser)
        {
            this.normuser = normuser;
            this.usmanager = usmanager;
        }
        public ActionResult Register()
        {
            return View();
        }
        #region
        [HttpPost]
        public async Task<ActionResult> Register(NormalUser user)
        {
            if (ModelState.IsValid)
            {
                normuser.UserName = user.UserName;
                normuser.Email = user.Email;
                normuser.UserPassword = user.UserPassword;
                CreateUsers users = new CreateUsers();
                users.UserName = normuser.UserName;
                users.Email = normuser.Email;
                var resulter = await usmanager.CreateAsync(users, normuser.UserPassword);
                  if (resulter.Succeeded)
                  {
                      return RedirectToAction("SignIn", "Account");
                  }
                  else
                  {
                    foreach (var item in resulter.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            
            }
            return View((NormalUser)normuser);
        }
        #endregion
    }
}
