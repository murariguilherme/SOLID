using D_Correct.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace D_Correct.Abstracts
{
    public abstract class DeliverableMessage : IMessage, IDeliverable
    {
        private List<string> recipients;
        
        protected DeliverableMessage()
        {
            recipients = new List<string>();
        }
        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void AddRecipient(string recipent)
        {
            recipients.Add(recipent);
        }

        public List<string> GetRecipients()
        {
            return recipients;
        }

        public abstract void Send();
    }
}
