using System;
using System.Collections.Generic;
using System.Text;

namespace D_Correct.Interfaces
{
    public interface IMobileMessage: IMessage, IDeliverable
    {
        void AddNumberToContacts(string number);
    }
}
