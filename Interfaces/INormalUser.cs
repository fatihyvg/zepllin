namespace zepllin.Interfaces
{
    public interface INormalUser
    {
        string UserId
        {
            get;
            set;
        }
        string UserName
        {
            get;
            set;
        }
        string Email
        {
            get;
            set;
        }
        string UserPassword
        {
            get;
            set;
        }
    }
}
