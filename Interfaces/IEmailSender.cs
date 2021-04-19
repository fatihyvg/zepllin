using zepllin.EmailConfig;
namespace zepllin.Interfaces
{
   public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
