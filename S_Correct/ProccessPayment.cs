using System;
using System.Collections.Generic;
using System.Text;
using S_Correct.Domains;

namespace S_Correct
{
    public static class ProccessPaymentSalary
    {
        public static void Proccess(Employeer employeer)
        {
            Console.WriteLine($"Processing payment of {employeer.Name}...");
            Console.WriteLine("Completed.");
            return;
        }
    }
}
