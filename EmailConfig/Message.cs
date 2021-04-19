using System.Collections.Generic;
using System.Linq;
using MimeKit;

namespace zepllin.EmailConfig
{
    public class Message
    {
        #region
        public Message(IEnumerable<string> to, string subject, string content)
        {
            To = new List<MailboxAddress>();
            To.AddRange(to.Select(x => new MailboxAddress(x)));
            Subject = subject;
            Content = content;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Content
        {
            get;
            set;
        }
        public List<MailboxAddress> To
        {
            get;
            set;
        }
        #endregion
    }
}
