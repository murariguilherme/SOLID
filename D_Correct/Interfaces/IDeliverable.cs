using System;
using System.Collections.Generic;
using System.Text;

namespace D_Correct.Interfaces
{
    public interface IDeliverable
    {
        void AddRecipient(string recipent);
        abstract public void Send();
        List<string> GetRecipients();
    }
}
