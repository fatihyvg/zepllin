using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;

namespace zepllin.Controllers
{
    public class ResetPasswordController : Controller
    {
        private readonly IChangePassword chgpassword;

        private readonly UserManager<CreateUsers> usmanager;

        private readonly SignInManager<CreateUsers> signmanager;
        public ResetPasswordController(UserManager<CreateUsers> usmanager, SignInManager<CreateUsers> signmanager, IChangePassword chgpassword)
        {
            this.usmanager = usmanager;
            this.chgpassword = chgpassword;
            this.signmanager = signmanager;
        }
        public ActionResult ResetPass(string token, string email)
        {
            if (token == null && email == null)
            {
                ModelState.AddModelError("", "Invalid Token Error.");
            }
            else
            {
                if (token != null && email != null)
                {
                    chgpassword.Token = token;
                    chgpassword.Email = email;
                }
            }
            return View((ChangePassword)chgpassword);
        }
        #region
        [HttpPost]
        public async Task<ActionResult> ResetPass(ChangePassword chgpassword)
        {
            if (ModelState.IsValid)
            {
                chgpassword.Email = chgpassword.Email;
                chgpassword.Password = chgpassword.Password;
                chgpassword.Token = chgpassword.Token;
                var user = await usmanager.FindByEmailAsync(chgpassword.Email);
                if (user != null)
                {
                    var result = await usmanager.ResetPasswordAsync(user, chgpassword.Token, chgpassword.Password);

                    if (result.Succeeded)
                    {
                        ViewBag.PasswordSucceedMessage = "Password Changed";
                    }
                    else
                    {
                        ViewBag.PasswordErrorMessage = "Password Wrong";
                    }
                    foreach (var errorlist in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, errorlist.Description);
                    }
                    return View(chgpassword);
                }

            }
            return View(chgpassword);
        }
        #endregion
    }
}
