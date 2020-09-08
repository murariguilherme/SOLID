using System;
using System.Collections.Generic;
using System.Text;
using S_Correct.Domains;

namespace S_Correct
{
    public static class SalaryEmployeerCalculator
    {
        public static void Calculate(Employeer employeer, int currentMonthHoursWorked)
        {
            var amountsalary = (employeer.MonthSalary / employeer.MonthHours) * currentMonthHoursWorked;
            Console.WriteLine($"Amount salary: {amountsalary:C2}.");
            return;
        }
    }
}
