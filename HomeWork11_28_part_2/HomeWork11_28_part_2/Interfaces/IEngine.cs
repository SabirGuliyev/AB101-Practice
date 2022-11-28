using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_28_part_2.Interfaces
{
    internal interface IEngine
    {
        public double OilCapacity { get; set; }
        public double CurrentOil { get; set; }
        public string OilType { get; set; }

        public void RemainOilAmount();
        
    }
}
