using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_24.Models
{
    internal class Product
    {
        private string _name;
        private decimal _price;

        public string Name
        {
            get { return _name; }
            set 
            {
                if (value.Trim().Length>0)
                {
                    _name = value.Trim();
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
        public decimal Price 
        { 
            get 
            { 
                return _price;
            } 
            set 
            { 
                if (value > 0.1m)
                {
                    _price = value;
                }
            } 
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
