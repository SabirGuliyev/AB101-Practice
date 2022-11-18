using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_18.Models
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public byte Age;

        public Person( string name,string surname,byte age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }
    }
}
