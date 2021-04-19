using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using zepllin.Interfaces;
namespace zepllin.Models
{
    public class Comments : IComments
    {
        [Key]
        public int CommentId
        {
            get;
            set;
        }
        public string CommentContents
        {
            get;
            set;
        }
        [ForeignKey("comment_fk")]
        public int CommentFk
        {
            get;
            set;
        }
        public string CommentUserName
        {
            get;
            set;
        }
        public string CommentDate
        {
            get;
            set;
        }
    }
}
