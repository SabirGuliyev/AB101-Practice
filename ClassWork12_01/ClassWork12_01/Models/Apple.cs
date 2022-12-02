using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork12_01.Models
{
    internal class Apple : Fruit
    {
        public int VitaminA { get; set; }

        public override void Smell()
        {
            Console.WriteLine("Smells like an Apple");
        }
    }
    internal class Banana : Fruit
    {
        public int VitaminB { get; set; }
        public override void Smell()
        {
            Console.WriteLine("Smells like an Banana");
        }
    }
    internal class Orange : Fruit
    {
        public int VitaminC { get; set; }
        public override void Smell()
        {
            Console.WriteLine("Smells like an Orange");
        }
    }
}
