using System;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller,IRandomFolderName
    {
        private readonly SignInManager<CreateUsers> signinmanager;

        private readonly INormalLogin normuser;

        public AccountController(SignInManager<CreateUsers> signinmanager, INormalLogin normuser)
        {
            this.signinmanager = signinmanager;
            this.normuser = normuser;
        }
        public ActionResult SignIn()
        {
            return View();
        }
        #region
        /*TODO AccountController Üye Girişi*/
        [HttpPost]
        public async Task<ActionResult> SignIn(NormalLogin user,string returnUrl)
        {
            
            if (ModelState.IsValid)
            {
                normuser.UserName = user.UserName;
                normuser.UserPassword = user.UserPassword;
                var loginresult = await signinmanager.PasswordSignInAsync(normuser.UserName, normuser.UserPassword, false, false);
                if (loginresult.Succeeded)
                {
                    
                    var Id = await signinmanager.UserManager.FindByNameAsync(normuser.UserName);
                    HttpContext.Session.SetString("realemail", Id.Email);
                    HttpContext.Session.SetString("realusername", normuser.UserName);
                    HttpContext.Session.SetString("userguidid", Convert.ToString(RandFolderName(Id.Id))); 
                    int param = Convert.ToInt32(HttpContext.Session.GetString("userguidid").Substring(1,8));
                    returnUrl = Url.Action("MyProfile", "Profile",new { UserNormalId = param });
                    ViewData["returnUrl"] = returnUrl;
                    if (Url.IsLocalUrl(returnUrl) && !string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                }
                ModelState.AddModelError(string.Empty, "User Name Or Password Wrong.");
            }

            return View((NormalLogin)normuser);
        }
        // TODO create random folder number
        public BigInteger RandFolderName(string guid)
        {
            Guid gparses = Guid.Parse(guid);
            return new BigInteger(BitConverter.ToInt32(gparses.ToByteArray()));
           
        }
        #endregion
    }
}
