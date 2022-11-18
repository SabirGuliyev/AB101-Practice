using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_18.Models
{
    internal class Student:Person
    {
        public string Group;
        public byte[] Points;
        public Student(string name,string surname,byte age,string group):base(name,surname,age)
        {
            Group=group;
            Points = new byte[0];
        }
    }
}
