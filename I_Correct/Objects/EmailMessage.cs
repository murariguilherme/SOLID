using I_Correct.Abstracts;
using I_Correct.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace I_Correct.Objects
{
    public class EmailMessage : DeliverableMessage, IEmailMessage
    {
        public void AddAttach()
        {
            Console.WriteLine($"Attaching something..");
        }

        public void AddSubject()
        {
            Console.WriteLine($"Adding subject..");
        }

        public void RequestReadReceipt()
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
