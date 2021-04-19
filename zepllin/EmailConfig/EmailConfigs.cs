
namespace zepllin.EmailConfig
{
    public class EmailConfigs
    {
        #region
        public EmailConfigs()
        {
            UserName = "";
            Password = "";
            From = "";
            SmtpServer = "";
            Port = 587;
        }
        public string From
        {
            get;
            private set;
        }
        public string SmtpServer
        {
            get;
            private set;
        }
        public string UserName
        {
            get;
            private set;
        }
        public string Password
        {
            get;
            private set;
        }
        public int Port
        {
            get;
            private set;
        }
        #endregion
    }
}
