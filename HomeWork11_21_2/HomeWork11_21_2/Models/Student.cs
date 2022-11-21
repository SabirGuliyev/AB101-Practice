using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_21_2.Models
{
    internal class Student:Person
    {
        public bool IsOnline;
    public Student(string name, string surname , byte age, bool isonline):base(name,surname,age)
        {
            IsOnline = isonline;
        }
    }
}
