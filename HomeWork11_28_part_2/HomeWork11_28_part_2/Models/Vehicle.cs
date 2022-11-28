using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_28_part_2.Models
{
    internal abstract class Vehicle
    {
        private double _path;
        private double _time;

        public double Path
        {
            get { return _path; }
            set {
                if (value>0)
                {
                    _path = value;
                }
                
            }
        }
        public double Time
        {
            get { return _time; }
            set
            {
                if (value > 0)
                {
                    _time = value;
                }

            }
        }
        public virtual void AverageSpeed()
        {
            Console.WriteLine(Path/Time);
        }
    }
}
