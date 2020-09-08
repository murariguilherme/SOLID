using System;
using System.Collections.Generic;
using System.Text;

namespace I_Wrong.Domains
{
    public class EmailMessage : IEmailMessage
    {
        public override void AddAttach()
        {
            Console.WriteLine($"Attaching something..");
        }

        public override void AddMessage(string message)
        {
            Console.WriteLine($"Writing a e-mail message..");
        }

        public override void AddSubject()
        {
            Console.WriteLine($"Adding subject..");
        }

        public override void RequestReadReceipt()
        {
            Console.WriteLine($"Request a read receipt.");
        }

        public override void Send()
        {
            foreach (var recipent in this.GetRecipients())
            {
                Console.WriteLine($"Sending a e-mail message to {recipent}.");
            }            
        }
    }
}
