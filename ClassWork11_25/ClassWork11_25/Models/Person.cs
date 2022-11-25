using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork11_25.Models
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public abstract void GetFullInfo();
    }
}
