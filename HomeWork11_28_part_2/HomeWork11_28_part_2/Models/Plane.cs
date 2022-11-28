using HomeWork11_28_part_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_28_part_2.Models
{
    internal class Plane:Vehicle,IEngine
    {
        private int _wingLength;

        public int WingLength
        {
            get { return _wingLength; }
            set {
                if (value>0)
                {
                    _wingLength = value;
                }
            }
        }
        public double OilCapacity { get; set; }
        public double CurrentOil { get; set; }
        public string OilType { get; set; }


        public void RemainOilAmount()
        {
            Console.WriteLine(OilCapacity - CurrentOil);
        }
    }
}
