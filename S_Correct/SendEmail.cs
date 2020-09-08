using System;
using System.Collections.Generic;
using System.Text;

namespace S_Correct
{
    public static class SendEmail
    {
        public static void Send(string employeerEmail, string emailBody)
        {
            Console.WriteLine($"Email sent to {employeerEmail} -> {emailBody}");
        }
    }
}
