using System;
using System.Collections.Generic;
using System.Text;

namespace S_Correct.Domains
{
    public class Employeer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal MonthSalary { get; set; }
        public int MonthHours { get; set; }
        public string Email { get; set; }
    }
}
