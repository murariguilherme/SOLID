using System;
using System.Collections.Generic;
using System.Text;

namespace D_Correct.Objects
{
    public static class Factory
    {
        public static EmailMessage GetEmailMessage()
        {
            return new EmailMessage();
        }
        public static MobileMessage GetMobileMessage()
        {
            return new MobileMessage();
        }
    }
}