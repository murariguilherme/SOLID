using System;
using System.Collections.Generic;
using System.Text;

namespace I_Wrong.Domains
{
    public abstract class IEmailMessage
    {
        private List<string> recipients;
        
        protected IEmailMessage()
        {
            recipients = new List<string>();
        }

        public List<string> GetRecipients()
        {
            return recipients;
        }

        abstract public void Send();
        abstract public void AddAttach();
        abstract public void AddSubject();
        abstract public void RequestReadReceipt();
        abstract public void AddMessage(string message);
        public void AddRecipient(string recipent)
        {
            recipients.Add(recipent);
        }
    }
}
