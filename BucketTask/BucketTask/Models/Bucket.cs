using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucketTask.Models
{
    internal class Bucket
    {
        private Flower _flower;
        private uint _flowerCount;
        private float _discountPercent;
        public uint FlowerCount
        {
            get => _flowerCount;
            set
            {
                if (value < 200)
                {
                    _flowerCount = value;
                }
            }
        }
        public float DiscountPercent
        { 
            get => _discountPercent;
            set
            {
                if (value >= 0 && value <= 100)
                {
                    _discountPercent = value;
                }
            }
        }

        public void AddFlower(Flower flower)
        {
            if (FlowerCount == 0) // _flower == null
            {
                _flower = flower;
                FlowerCount = 1;
            }
            else if (_flower == flower && flower != null)
            {
                FlowerCount++;
            }
        }
        public (float Price, bool HasFlower) TotalPrice()
        {
            if (FlowerCount >= 1)
            {
                return (_flower.Price * FlowerCount * (100 - DiscountPercent) / 100, true);
            }
            else
            {
                return (0, false);
            }
        }

    }
}
