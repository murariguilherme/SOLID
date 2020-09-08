using System;
using S_Wrong.Domains;
namespace S_Wrong
{
    class Program
    {
        //The Employeer class do too much things.
        //A good method is separate responsabilities, like a Email class and a salary calculator class.
        
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

            employeer.CalculateSalary(200);
            employeer.ProcessPayment();
            employeer.SendEmailEmployeerSalary();
            Console.ReadLine();
        }
    }
}
