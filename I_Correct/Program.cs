using I_Correct.Objects;
using System;

namespace I_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            var mobile = new MobileMessage();
            mobile.WriteMessage("Hello how are you? This is a sms marketing, do you wanna buy something?");
            mobile.AddRecipient("+39-319-555-7749685");
            mobile.AddRecipient("+39-320-555-7828092");
            mobile.Send();

            Console.WriteLine();

            var email = new EmailMessage();
            email.WriteMessage("Please this is an e-mail verification.");
            email.AddSubject();
            email.AddAttach();
            email.AddRecipient("3elegantyoung360q@studio300.com");
            email.AddRecipient("ykarim.sayed.336z@walmartttonlines.com");
            email.AddRecipient("wrusell@gothill.com");
            email.RequestReadReceipt();
            email.Send();

            Console.ReadLine();
        }
    }
}
