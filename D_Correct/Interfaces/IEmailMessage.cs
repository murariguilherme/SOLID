using System;
using System.Collections.Generic;
using System.Text;

namespace D_Correct.Interfaces
{
    public interface IEmailMessage: IMessage, IDeliverable
    {
        abstract public void AddAttach();
        abstract public void AddSubject();
        abstract public void RequestReadReceipt();
    }
}
