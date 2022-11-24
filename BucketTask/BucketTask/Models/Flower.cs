using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketTask.Models
{
    internal record Flower
    {
        private string _name;
        private float _price;
        public string Name
        {
            get => _name;
            set 
            {
                if (value.Trim().Length >= 3)
                {
                    _name = value.Trim();
                }
            }
        }
        public string Color { get; set; }
        public float Price {
            get => _price;
            set
            {
                if (value > 0.09f)
                {
                    _price = value;
                }
            }
        }
    }
}
