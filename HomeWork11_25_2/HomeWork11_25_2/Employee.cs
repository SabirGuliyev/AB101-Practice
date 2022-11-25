using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_25_2
{
    internal class Employee
    {
        string _name;
        bool _isSuccessfull;
        decimal _salary;

        public string Name { get { return _name; } set { _name = value; } }
        public bool IsSuccessfull 
        {
            get { return _isSuccessfull; }
            set { _isSuccessfull = value; } 
        }
        public decimal Salary { get { return _salary; } set { _salary=value; } }
        public Employee(string name, bool isSuccessfull, decimal salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
        }
    }
}
