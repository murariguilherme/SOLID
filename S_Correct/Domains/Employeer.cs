using System;
using System.Collections.Generic;
using System.Text;

namespace S_Correct.Domains
{
    public class Employeer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double MonthSalary { get; set; }
        public int MonthHours { get; set; }
        public string Email { get; set; }

        public double CalculateSalary(int currentMonthHoursWorked)
        {
            var amountsalary = (this.MonthSalary / this.MonthHours) * currentMonthHoursWorked;
            Console.WriteLine($"Amount salary: {amountsalary:C2}.");
            return amountsalary;
        }

        public bool ProcessPayment()
        {
            Console.WriteLine("Processing payment...");            
            Console.WriteLine("Completed.");
            return true;
        }

        public void SendEmailEmployeerSalary()
        {
            Console.WriteLine($"Email sent to {this.Email} -> Your salary was paid.");
        }
    }
}
