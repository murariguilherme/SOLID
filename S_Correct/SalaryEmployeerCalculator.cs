using System;
using System.Collections.Generic;
using System.Text;
using S_Correct.Domains;

namespace S_Correct
{
    public static class SalaryEmployeerCalculator
    {
        public static decimal Calculate(Employeer employeer, int currentMonthHoursWorked)
        {
            return ((employeer.MonthSalary / employeer.MonthHours) * currentMonthHoursWorked);           
        }
    }
}
