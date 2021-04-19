using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using zepllin.EmailConfig;
using zepllin.Interfaces;
using zepllin.Models;

namespace zepllin.Controllers
{
    #region
    [AllowAnonymous]
    public class ForgotPasswordController : Controller
    {
        private readonly UserManager<CreateUsers> signinmanager;

        private readonly IEmailSender emailsend;

        private readonly IForgotPassword forgotpass;

        private const string refreshmessage = "Password Refresh";

        private string[] mainemailsender = { "zepllinphotograph@gmail.com" };
        public ForgotPasswordController(UserManager<CreateUsers> signinmanager, IEmailSender emailsend, IForgotPassword forgotpass)
        {
            this.signinmanager = signinmanager;
            this.emailsend = emailsend;
            this.forgotpass = forgotpass;
        }
        public ActionResult Index()
        {
            return View(); 
        }
        #region
        /*TODO ForgotPasswordController Şifremi Unuttum*/
        [HttpPost]
        public async Task<ActionResult> Index(ForgotPassword pass)
        {
            if (ModelState.IsValid)
            {
                forgotpass.Email = pass.Email;
                if (forgotpass.Email != null)
                {
                    var emailresult = await signinmanager.FindByEmailAsync(forgotpass.Email);
                    if (emailresult != null)
                    {                    
                        var token = await signinmanager.GeneratePasswordResetTokenAsync(emailresult);
                        var resetsite = Url.Action("ResetPass", "ResetPassword", new { token, email = pass.Email }, Request.Scheme);
                        ViewBag.EmailMessage = "Email Send";
                        Message messages = new Message(mainemailsender, refreshmessage, resetsite);
                        emailsend.SendEmail(messages);
                    }
                }
            }
            return View(pass);
        }
        #endregion
    }
    #endregion
}
