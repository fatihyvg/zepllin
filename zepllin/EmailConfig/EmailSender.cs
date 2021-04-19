using System;
using MimeKit;
using MailKit.Net.Smtp;
using zepllin.Interfaces;

namespace zepllin.EmailConfig
{
    public class EmailSender : EmailConfigs,IEmailSender
    {
        #region
        public void SendEmail(Message message)
        {
            MimeMessage emmessage = CreateMessage(message);
            SendSmtpEmail(emmessage);
        }
        private MimeMessage CreateMessage(Message message)
        {
            MimeMessage mimemessage = new MimeMessage();
            mimemessage.From.Add(new MailboxAddress(base.From));
            mimemessage.To.AddRange(message.To);
            mimemessage.Subject = message.Subject;
            mimemessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };

            return mimemessage;
        }
        private void SendSmtpEmail(MimeMessage message)
        {
            SmtpClient smtp = new SmtpClient();

            try
            {
                smtp.Connect(SmtpServer, Port, false);
                smtp.AuthenticationMechanisms.Remove("XOAUTH2");
                smtp.Authenticate(UserName, Password);
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Email Error", ex.Message);
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }
        }
        #endregion
    }
}
