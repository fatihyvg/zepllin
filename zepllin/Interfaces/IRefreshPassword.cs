namespace zepllin.Interfaces
{
    public interface IRefreshPassword
    {
        string OldPassword
        {
            get;
            set;
        }
        string NewPassword
        {
            get;
            set;
        }
        string RePassword
        {
            get;
            set;
        }
    }
}
