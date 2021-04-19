using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.ImageComponents
{
    public class ImageCommentContainer : ViewComponent
    {
        private readonly IDatabaseRepository<Comments> databasecomment;
        public ImageCommentContainer(IDatabaseRepository<Comments> databasecomment)
        {
            this.databasecomment = databasecomment;
        }
        public IViewComponentResult Invoke(int id)
        {
            List<Comments> commentlist = new List<Comments>();
            foreach (var commentitem in databasecomment.SpGetComments(id).ToList())
            {
                commentlist.Add(new Comments
                {
                    CommentId = commentitem.CommentId,
                    CommentFk = commentitem.CommentFk,
                    CommentUserName = commentitem.CommentUserName,
                    CommentDate = commentitem.CommentDate,
                    CommentContents = commentitem.CommentContents
                });
            }

            return View(commentlist.AsEnumerable());
        }
    }
}
