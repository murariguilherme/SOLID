using System;
using System.Collections.Generic;
using System.Text;

namespace I_Correct.Interfaces
{
    public interface IEmailMessage
    {
        abstract public void AddAttach();
        abstract public void AddSubject();
        abstract public void RequestReadReceipt();
    }
}
