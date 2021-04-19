namespace zepllin.Interfaces
{
    public interface IChangePassword
    {
        string Email
        {
            get;
            set;
        }
        string Password
        {
            get;
            set;
        }
        string ConfirmPassword
        {
            get;
            set;
        }
        string Token
        {
            get;
            set;
        }
    }
}
