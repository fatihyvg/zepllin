using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using zepllin.Extra;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [Authorize]
    [Route("Profile")]
    public class ProfileController : Controller
    {
        private readonly SignInManager<CreateUsers> signout;

        private readonly IDatabaseRepository<UserImages> databaseuserimages;

        private readonly IDatabaseRepository<Vote> voterepository;

        private readonly IUserImages userimage;

        private readonly IVote votes;
        public ProfileController(SignInManager<CreateUsers> signout, 
            IUserImages userimage, 
            IDatabaseRepository<UserImages> databaseuserimages,
            IVote votes,IDatabaseRepository<Vote> voterepository)
        {
            this.signout = signout;
            this.userimage = userimage;
            this.databaseuserimages = databaseuserimages;
            this.votes = votes;
            this.voterepository = voterepository;
        }
        public ActionResult MyProfile()
        {
            ViewData["changepass"] = HttpContext.Session.GetString("realıd");
            return View();
        }
        /*TODO Profil*/
        [Route("MyProfile/{UserNormalId:int}")]
        public ActionResult MyProfile(int UserNormalId)
        {
            List<UserImages> listprofileimage = new List<UserImages>();
         
            foreach (var item in databaseuserimages.SpGetUserByImages(UserNormalId).ToList())
            {
                if(item.ImageApprove == 1)
                {
                    listprofileimage.Add(new UserImages
                    {
                        ImageId = item.ImageId,
                        ImageTitle = item.ImageTitle,
                        ImageSrc = item.ImageSrc,
                        ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                        ImageApprove = item.ImageApprove,
                        ImageCategoryFk = item.ImageCategoryFk,
                        UserNormalId = item.UserNormalId,
                    });
                    ViewBag.Laster = listprofileimage;
                    ViewData["username"] = item.UserName;
                }
           
            }
            return View(listprofileimage.AsEnumerable());
        }
        [Route("UserSıgnOut")]
        public async Task<ActionResult> UserSıgnOut()
        {
            await signout.SignOutAsync();
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home"); 
        }
        /*TODO Upload Bölümü*/
        #region
        [HttpPost]
        [Route("UploadImages")]
        public async Task<JsonResult> UploadImages(IFormFile imagefile, string imagecategory, string imagetitle)
        {
                    Random rand = new Random();
                    int randomnumber = rand.Next();
                    ExifReader exif = new ExifReader(imagefile.OpenReadStream());
                    string imgpath = string.Concat(RootFolder.RootFolderWithSubFolderAndSlash,GuidFolderName);
                    string uploadpath = Path.GetFullPath(imgpath);
                    if (!Directory.Exists(uploadpath))
                    {
                        Directory.CreateDirectory(uploadpath);
                    }
                    string filenames = string.Concat(Convert.ToString(randomnumber),Path.GetExtension(imagefile.FileName.ToLower()));
                    string fullpath = Path.Combine(uploadpath,filenames);
                    string repfilename = Path.Combine(imgpath,filenames);
                    ApplyImageInfos(UrlSeo.ConvertToSeoUrl(imagetitle),
                        imagetitle,
                        imagecategory,
                        repfilename.Substring(9).Replace(@"\",@"/"),
                        GuidFolderName,
                        HttpContext.Session.GetString("realusername"),
                        HttpContext.Session.GetString("realemail"), 
                        Convert.ToString(randomnumber),
                        Convert.ToString(0),
                        Convert.ToString(0),
                        Convert.ToString(exif.ExifIso),
                        Convert.ToString(exif.ExifFNumber),
                        Convert.ToString(exif.ExifFocalLength),
                        Convert.ToString(exif.ExifLensModel),
                        Convert.ToString(exif.ExifMeteringMode),
                        Convert.ToString(exif.ExifModel),
                        Convert.ToString(exif.ExifShutterSpeedValue),
                        Convert.ToString(exif.ExifExposureMode),
                        Convert.ToString(exif.ExifExposureProgram),
                        Convert.ToString(exif.ExifExposureTime),
                        Convert.ToString(exif.ExifMake));
                    using (FileStream filewriter = new FileStream(fullpath, FileMode.Create))
                    {
                        await imagefile.CopyToAsync(filewriter);
                        filewriter.Close();
                        filewriter.Dispose();
                    }
            return Json((UserImages)userimage);
        }
        /*Upload Procedure*/
        #endregion
        private void ApplyImageInfos(params string[] lists)
        {
                userimage.ImageWithoutSeoTitle = lists[0];
                userimage.ImageTitle = lists[1];
                userimage.ImageCategoryFk = Convert.ToInt32(lists[2]);                 
                userimage.ImageSrc = lists[3];
                userimage.UserNormalId = Convert.ToInt32(lists[4]);
                userimage.UserName = lists[5];
                userimage.UserEmail = lists[6];
                userimage.ImageNewNumber = lists[7];
                userimage.ImageApprove = Convert.ToInt32(lists[8]);
                userimage.ImageEdıtor = Convert.ToInt32(lists[9]);
                userimage.ImageExifIso = lists[10];
                userimage.ImageExifFNumber = string.Format("f{0}", lists[11]);
                userimage.ImageExifFocalLength = lists[12];
                userimage.ImageExifLensModel = lists[13];
                userimage.ImageExifMeteringMode = lists[14];
                userimage.ImageExifModel = lists[15];
                userimage.ImageExifShutterSpeedValue = lists[16];
                userimage.ImageExifExposureMode = lists[17];
                userimage.ImageExifExposureProgram = lists[18];
                userimage.ImageExifExposureTime = lists[19];
                userimage.ImageExifMake = lists[20];

                  databaseuserimages.SpUploadImage(
                         userimage.ImageWithoutSeoTitle,
                         userimage.ImageTitle,
                         userimage.ImageCategoryFk,
                         userimage.ImageSrc,
                         userimage.UserNormalId,
                         userimage.UserName,
                         userimage.UserEmail,
                         userimage.ImageNewNumber,
                         userimage.ImageApprove,
                         userimage.ImageEdıtor,
                         userimage.ImageExifIso,
                         userimage.ImageExifFNumber,
                         userimage.ImageExifFocalLength,
                         userimage.ImageExifLensModel,
                         userimage.ImageExifMeteringMode,
                         userimage.ImageExifModel,
                         userimage.ImageExifShutterSpeedValue,
                         userimage.ImageExifExposureMode,
                         userimage.ImageExifExposureProgram,
                         userimage.ImageExifExposureTime,
                         userimage.ImageExifMake);
            AddVote(0,Convert.ToInt32(userimage.ImageNewNumber));
        }
        /*Dosya İsmi*/
        private void AddVote(int vote,int votefkıd)
        {
            try
            {
                votes.VoteNumbers = vote;
                votes.VoteContentId = votefkıd;
                voterepository.SpVoteAdd(votes.VoteNumbers,votes.VoteContentId);
            }
            catch(Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }  
        }
        #region
        private string GuidFolderName
        {
            get
            {
                return HttpContext.Session.GetString("userguidid").Substring(1, 8);
            }
        }
        #endregion
    }

}

