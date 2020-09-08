using System;
using System.Collections.Generic;
using System.Text;

namespace I_Wrong.Domains
{
    public class SmsMessage : IEmailMessage
    {
        public override void AddAttach()
        {
            throw new NotImplementedException();
        }

        public override void AddMessage(string message)
        {
            Console.WriteLine($"Writing a SMS message..");
        }

        public override void AddSubject()
        {
            throw new NotImplementedException();
        }

        public override void RequestReadReceipt()
        {
            throw new NotImplementedException();
        }

        public override void Send()
        {
            foreach (var recipent in this.GetRecipients())
            {
                Console.WriteLine($"Sending a SMS message to {recipent}.");
            }
        }
    }
}
