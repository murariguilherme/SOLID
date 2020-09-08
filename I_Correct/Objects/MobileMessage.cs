using I_Correct.Abstracts;
using I_Correct.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace I_Correct.Objects
{
    public class MobileMessage : DeliverableMessage, IMobileMessage
    {
        public void AddNumberToContacts(string number)
        {
            Console.WriteLine($"Adding {number} to contacts..");
        }

        public override void Send()
        {
            foreach (var recipent in this.GetRecipients())
            {
                Console.WriteLine($"Sending a SMS message to {recipent}.");
                AddNumberToContacts(recipent);
            }
        }
    }
}
