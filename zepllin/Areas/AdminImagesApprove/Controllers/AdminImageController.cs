using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
using zepllin.Extra;
using zepllin.EmailConfig;
namespace zepllin.Areas.AdminImagesApprove.Controllers
{
    #region
    [Area("AdminImagesApprove")]
    [Route("AdminImage")]
    [Authorize(Roles = "Admin,Manager")]
    public class AdminImageController : Controller
    {

        private readonly IDatabaseRepository<UserImages> adminmanageimage;

        private readonly UserManager<CreateUsers> postusermail;

        private readonly IEmailSender emailsend;

        private UserImages userimages;
        public AdminImageController(IDatabaseRepository<UserImages> adminmanageimage,
            UserManager<CreateUsers> postusermail,
            IEmailSender emailsend)
        {
            this.adminmanageimage = adminmanageimage;
            this.postusermail = postusermail;
            this.emailsend = emailsend;

        }
        /*TODO Onaylama Id yE Göre Getirme*/
        public ActionResult Index(int? ıd)
        {
            Stack<UserImages> listimgs = new Stack<UserImages>();
            if (ModelState.IsValid)
            {
                foreach (var item in adminmanageimage.GetAllList().Where(m => m.ImageId == ıd).Select(m => new { 
                    ImageId = m.ImageId, 
                    ImageSrc = m.ImageSrc, 
                    ImageWithoutSeoTitle = m.ImageWithoutSeoTitle,
                    UserName = m.UserName,
                    UserEmail = m.UserEmail,
                    ImageExifExposureMode = m.ImageExifMeteringMode,
                    ImageExifExposureProgram = m.ImageExifExposureProgram,
                    ImageExifExposureTime = m.ImageExifExposureTime,
                    ImageExifFNumber = m.ImageExifFNumber,
                    ImageExifFocalLength = m.ImageExifFocalLength,
                    ImageExifIso = m.ImageExifIso,
                    ImageExifLensModel = m.ImageExifLensModel,
                    ImageExifMake = m.ImageExifMake,
                    ImageExifMeteringMode = m.ImageExifMeteringMode,
                    ImageExifModel = m.ImageExifModel,
                    ImageExifShutterSpeedValue = m.ImageExifShutterSpeedValue
                }).ToArray())
                {
                    listimgs.Push(new UserImages
                    {
                        ImageId = item.ImageId,
                        ImageSrc = item.ImageSrc,
                        ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                        UserName = item.UserName,
                        UserEmail = item.UserEmail,
                        ImageExifExposureMode = item.ImageExifExposureMode,
                        ImageExifExposureProgram = item.ImageExifExposureProgram,
                        ImageExifExposureTime = item.ImageExifExposureTime,
                        ImageExifFNumber = item.ImageExifFNumber, 
                        ImageExifFocalLength = item.ImageExifFocalLength,
                        ImageExifIso = item.ImageExifIso,
                        ImageExifLensModel = item.ImageExifLensModel,
                        ImageExifMake = item.ImageExifMake,
                        ImageExifMeteringMode = item.ImageExifMeteringMode,
                        ImageExifModel = item.ImageExifModel,
                        ImageExifShutterSpeedValue = item.ImageExifShutterSpeedValue,
                        
                    });
                }
            }
            return View(listimgs.AsEnumerable());
        }
        /*TODO Onaylama*/
        [HttpPost]
        [Route("Approveyes/{yes:int}")]
        public ActionResult Approveyes(int? yes,string email)
        {
               
                if (yes is not null)
                {
                    ApproveUpdate(yes,1, "ImageApprove");
                    EmailToSending(email);
                }
            return Content(string.Empty);
        }
        /*TODO Onaylamama*/
        [HttpPost]
        [Route("Approveno/{no:int}")]
        public ActionResult Approveno(int? no, string appimgsrc = null)
        {
            string path = Path.Combine(RootFolder.RootFolderName, appimgsrc);
            string fpath = Path.GetFullPath(path);

            if (System.IO.File.Exists(fpath))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
                System.IO.File.Delete(fpath);
                adminmanageimage.DeleteFromDatabase(no);
                adminmanageimage.Save();
            }
            return Content(string.Empty);
        }
        /*TODO Ana Sayfada Listeleme*/
        [HttpPost]
        [Route("BestOfPhoto/{photo:int}")]
        public ActionResult BestOfPhoto(int? photo)
        {
            if(photo is not null)
            {
                ApproveUpdate(photo,2, "ImageEdıtor");
            }
            return Content(string.Empty);
        }
        [HttpPost]
        [Route("UpdateToZero/{upzero:int}")]
        public ActionResult UpdateToZero(int? upzero)
        {
            if(upzero is not null)
            {
                ApproveUpdate(upzero,3,"ImageEdıtor");
            }
            return Content(string.Empty);
        }
        /*TODO Onaylama Durumu*/
        #region
        private void ApproveUpdate(int? ıd,int count,string prop)
        {
             userimages = new UserImages();
            if (ıd != null && count == 1 && prop == "ImageApprove")
            {
                userimages = adminmanageimage.FindAndGetById(ıd);
                userimages.ImageApprove = 1;
                adminmanageimage.UpdateFromDatabase(userimages);
                adminmanageimage.Save();
            }
            else if(ıd != null && count == 2 && prop == "ImageEdıtor")
            {
                    userimages = adminmanageimage.FindAndGetById(ıd);
                    userimages.ImageEdıtor = 1;
                    adminmanageimage.UpdateFromDatabase(userimages);
                    adminmanageimage.Save();
            }
            else
            {
                if(ıd != null && count == 3 && prop == "ImageEdıtor")
                {
                    userimages = adminmanageimage.FindAndGetById(ıd);
                    userimages.ImageEdıtor = 0;
                    adminmanageimage.UpdateFromDatabase(userimages);
                    adminmanageimage.Save();
                }
            }
        }
        private async void EmailToSending(string username)
        {
            if (username != null || username != null)
            {
                var name = await postusermail.FindByEmailAsync(username);
                string[] mail = { name.Email };
                Message message = new Message(mail, "New Photo Approved", "Your new photo has been approved\nVisit : https://www.zepllin.com");
                emailsend.SendEmail(message);
                postusermail.Dispose();
            }
            
        }
        #endregion
    }
    #endregion
}
