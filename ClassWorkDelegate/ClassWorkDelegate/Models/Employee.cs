using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkDelegate.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Gmail { get; set; }
        public Employee(string name, string gmail)
        {
            Name = name;
            Gmail = gmail;
        }
    }
}
