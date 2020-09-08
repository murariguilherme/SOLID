using I_Wrong.Domains;
using System;

namespace I_Wrong
{
    //No client should be forced to depend on methods it does not use
    //SMS class don't need to use attachment, subject, request read receipt.. 

    class Program
    {
        static void Main(string[] args)
        {
            var sms = new SmsMessage();
            sms.AddMessage("Hello how are you? This is a sms marketing, do you wanna buy something?");
            sms.AddRecipient("+39-319-555-7749685");
            sms.AddRecipient("+39-320-555-7828092");
            sms.Send();

            Console.WriteLine();

            var email = new EmailMessage();            
            email.AddMessage("Please this is an e-mail verification.");
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
