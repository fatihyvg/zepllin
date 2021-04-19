using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using zepllin.Models;
namespace zepllin.Controllers
{
    #region
    [Authorize]
    public class ChangePasswordController : Controller
    {
        private readonly UserManager<CreateUsers> changepassword;

        private readonly SignInManager<CreateUsers> resultpassmanager;
        public ChangePasswordController(UserManager<CreateUsers> changepassword,SignInManager<CreateUsers> resultpassmanager)
        {
            this.changepassword = changepassword;
            this.resultpassmanager = resultpassmanager;
        }
        public ActionResult ChangePassworder()
        {
            return View();
        }
        /*TODO CgangePasswordController Şifre Değiştirme*/
        [HttpPost]
        public async Task<ActionResult> ChangePassworder(RefreshPassword refpassword)
        {
            if (ModelState.IsValid)
            {
                var result = await changepassword.GetUserAsync(User);
                if (result == null)
                {
                    return RedirectToAction("MyProfile", "Profile");
                }
                var passresult = await changepassword.ChangePasswordAsync(result, refpassword.OldPassword, refpassword.NewPassword);

                if (!passresult.Succeeded)
                {
                    foreach (var error in passresult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }
                await resultpassmanager.RefreshSignInAsync(result);
                ViewData["PasswordChanged"] = "Password Changed";
            }
            return View(refpassword);
        }
    }
    #endregion
}
