using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork12_01.Models
{
    internal abstract class Fruit
    {
        public string Taste { get; set; }
        public int Water { get; set; }

        public abstract void Smell()
        
    }
}
