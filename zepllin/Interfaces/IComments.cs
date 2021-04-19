namespace zepllin.Interfaces
{
    public interface IComments
    {
        int CommentId
        {
            get;
            set;
        }
        string CommentContents
        {
            get;
            set;
        }
        int CommentFk
        {
            get;
            set;
        }
        string CommentUserName
        {
            get;
            set;
        }
        string CommentDate
        {
            get;
            set;
        }
    }
}
