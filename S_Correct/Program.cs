using System;
using S_Correct.Domains;

namespace S_Correct
{
    class Program
    {
        static void Main(string[] args)
        {
            Employeer employeer = new Employeer()
            {
                Email = "employeer@employeer.com",
                Id = Guid.NewGuid(),
                MonthHours = 220,
                MonthSalary = 2500,
                Name = "Ben Jhonson"
            };            

            SalaryEmployeerCalculator.Calculate(employeer, 200);
            ProccessPaymentSalary.Proccess(employeer);
            SendEmail.Send(employeer.Email, "Your salary was paid.");
        }
    }
}
