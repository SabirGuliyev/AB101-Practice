using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_25.Models
{
    internal abstract class Employee:Person
    {
        public short MonthHour { get; set; }
        public decimal SalaryForHour { get; set; }

        public virtual void CalculateSalary()
        {
            Console.WriteLine(MonthHour*SalaryForHour);
        }

     
    }
}
