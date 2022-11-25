using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_25.Models
{
    internal abstract class Developer:Employee
    {
        public bool IsFreelance { get; set; }
        public override void CalculateSalary()
        {
            if (IsFreelance)
            {
                SalaryForHour = 0;
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(MonthHour*SalaryForHour);
            }
        }

    }
}
