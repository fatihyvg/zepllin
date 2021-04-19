using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using zepllin.Interfaces;
using zepllin.Models;
using zepllin.Extra;
namespace zepllin.Controllers
{
    #region
    [Route("Image")]
    public class ImageController : Controller
    {
        private readonly IDatabaseRepository<UserImages> userimages;

        private readonly IDatabaseRepository<Vote> databasevote;

        private readonly IDatabaseRepository<Comments> databasecomment;

        private readonly IDatabaseRepository<Category> categoryrepository;

        private readonly IJsonCache<Category> categorycache;

        private readonly IJsonCache<UserImages> cacheimage;

        private readonly IUserImages user;

        private readonly IComments comments;

        private readonly IVote updatevote;
        public ImageController(IDatabaseRepository<UserImages> userimages,
            IJsonCache<UserImages> cacheimage,
            IDatabaseRepository<Vote> databasevote,
            IDatabaseRepository<Comments> databasecomment,
            IDatabaseRepository<Category> categoryrepository,
            IJsonCache<Category> categorycache,
            IVote updatevote,
            IUserImages user,
            IComments comments)
        {
            this.userimages = userimages;
            this.cacheimage = cacheimage;
            this.databasevote = databasevote;
            this.updatevote = updatevote;
            this.comments = comments;
            this.databasecomment = databasecomment;
            this.categoryrepository = categoryrepository;
            this.categorycache = categorycache;
            this.user = user;
        }
        [Route("Show")]
        public ActionResult Show()
        {
            return View();
        }
        /*TODO ImageController Route ıd ye göre getirme*/
        [Route("Show/{ImageId:int}/{ImageTitle}")]
        public ActionResult Show(int ImageId, string ImageTitle)
        {
            List<UserImages> usr = new List<UserImages>();
            List<Vote> votes = new List<Vote>();
            List<Category> newcategory = new List<Category>();
            foreach (var item in userimages.GetAllList().Where(t => t.ImageId == ImageId && t.ImageTitle == ImageTitle).Select(a => new { 
                ImageId = a.ImageId, 
                ImageTitle = a.ImageTitle,
                ImageWithoutSeoTitle = a.ImageWithoutSeoTitle,
                ImageSrc = a.ImageSrc,
                UserName = a.UserName,
                UserEmail = a.UserEmail,
                ImageExifExposureMode = a.ImageExifExposureMode,
                ImageExifExposureTime = a.ImageExifExposureTime,
                ImageExifExposureProgram = a.ImageExifExposureProgram,
                ImageExifFNumber = a.ImageExifFNumber,
                ImageExifFocalLength = a.ImageExifFocalLength,
                ImageExifIso = a.ImageExifIso,
                ImageExifLensModel = a.ImageExifLensModel,
                ImageExifMake = a.ImageExifMake,
                ImageExifMeteringMode = a.ImageExifMeteringMode,
                ImageExifModel = a.ImageExifModel,
                ImageExifShutterSpeedValue = a.ImageExifShutterSpeedValue
            }))
            {
            foreach (var voteitem in databasevote.SpGetVotes(item.ImageId).ToList())
            {
                    votes.Add(new Vote
                    {
                        VoteId = voteitem.VoteId,
                        VoteNumbers = voteitem.VoteNumbers,
                        VoteContentId = voteitem.VoteContentId
                    });
                }
                usr.Add(new UserImages
                    {
                        ImageId = item.ImageId,
                        ImageTitle = item.ImageTitle,
                        ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                        ImageSrc = item.ImageSrc,
                        UserName = item.UserName,
                        UserEmail = item.UserEmail,
                        ImageExifExposureMode = item.ImageExifExposureMode,
                        ImageExifExposureTime = item.ImageExifExposureTime,
                        ImageExifExposureProgram = item.ImageExifExposureProgram,
                        ImageExifFNumber = item.ImageExifFNumber,
                        ImageExifFocalLength = item.ImageExifFocalLength,
                        ImageExifIso = item.ImageExifIso,
                        ImageExifLensModel = item.ImageExifLensModel,
                        ImageExifMake = item.ImageExifMake,
                        ImageExifMeteringMode = item.ImageExifMeteringMode,
                        ImageExifModel = item.ImageExifModel,
                        ImageExifShutterSpeedValue = item.ImageExifShutterSpeedValue
                    });
                ViewBag.User = item.UserName;
                ViewBag.id = item.ImageId;
                ViewData["imagetitle"] = item.ImageWithoutSeoTitle;
                ViewData["url"] = item.ImageSrc;
                ViewData["urlıd"] = item.ImageId;
                ViewData["urltitle"] = item.ImageTitle;
            }
            foreach (var categoryloop in categoryrepository.GetAllList().ToList())
            {
                newcategory.Add(new Category
                {
                    CategoryId = categoryloop.CategoryId,
                    CategoryName = categoryloop.CategoryName
                });
            }
            ViewBag.VoteList = votes.AsEnumerable();
            ViewData["allcategory"] = categorycache.jsonCache(newcategory, "category", TimeSpan.FromDays(365));
            return View(cacheimage.jsonCache(usr.AsEnumerable() as List<UserImages>,"mainimages",TimeSpan.FromDays(7)));
        }
        /*TODO EditController Fotoğraf Silme*/
        [HttpPost]
        [Route("DeleteImageFromDisk/{ıd:int}")]
        public JsonResult DeleteImageFromDisk(int ıd, string imgsrc)
        {
            user.ImageId = ıd;
            user.ImageSrc = imgsrc;
            string path = Path.Combine(RootFolder.RootFolderName, user.ImageSrc);
            string fullpath = Path.GetFullPath(path);
            if (System.IO.File.Exists(fullpath))
            {
                using (FileStream ftr = new FileStream(fullpath, FileMode.Open, FileAccess.Read))
                {
                    ftr.Close();
                    ftr.Dispose();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    System.IO.File.Delete(fullpath);
                    userimages.SpDeleteImageFromDiskAndDatabase(user.ImageId);
                }
            }
            return Json((UserImages)user);
        }
        /*TODO Oy Güncelleme*/
        [HttpPost]
        public JsonResult UpdateVote(int count, int upvote)
        {
              updatevote.VoteContentId = Convert.ToInt32(count);
              updatevote.VoteNumbers = Convert.ToInt64(upvote);
              databasevote.SpUpdateVote(updatevote.VoteContentId, updatevote.VoteNumbers);
              return Json((Vote)updatevote);
        }
        [HttpPost]
        [Route("UpdateImages/{Id:int}")]
        public JsonResult UpdateImages(int Id, IFormCollection col)
        {
            user.ImageId = Id;
            user.ImageTitle = UrlSeo.ConvertToSeoUrl(col["imageupdatetitle"]);
            user.ImageWithoutSeoTitle = col["imageupdatetitle"];
            user.ImageCategoryFk = Convert.ToInt32(col["imageupdatecategory"]);
            userimages.SPUpdateImages(user.ImageId, user.ImageTitle, user.ImageWithoutSeoTitle, user.ImageCategoryFk);
            return Json((UserImages)user);
        }
        [HttpPost]
        [Route("AddComment")]
        [Route("AddComment/{commentcontents}/{commentfk:int}/{commentusername}")]
        public JsonResult AddComment(string commentcontents,int commentfk,string commentusername)
        {
            DateTime date = DateTime.Now;
            comments.CommentContents = commentcontents;
            comments.CommentFk = commentfk;
            comments.CommentUserName = commentusername;
            comments.CommentDate = date.ToString("F");
            if (comments.CommentContents != null || comments.CommentUserName != null || comments.CommentDate != null)
            {
                databasecomment.SpCommentAdd(comments.CommentContents, comments.CommentFk, comments.CommentUserName, comments.CommentDate);
            }
            else
            {
                if (comments.CommentContents == null || comments.CommentUserName == null || comments.CommentDate == null)
                {
                    return Json(string.Empty);
                }
            }
            return Json((Comments)comments);
        }
    }
    #endregion
}
