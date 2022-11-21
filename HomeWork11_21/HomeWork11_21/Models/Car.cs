using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_21.Models
{
    internal class Car : Vehicle
    {
        private string _brand;
        private string _model;
        double _fuelCapacity;
        double _currentFuel;
        public double FuelFor1Km;

        public double CurrentFuel
        {
            get { return _currentFuel; }
            set 
            {
                if (value<= _fuelCapacity && value>=0)
                {
                    _currentFuel = value;
                }
                else
                {
                    Console.WriteLine("Catmir");
                }
            }
        }




        public double FuelCapacity
        {
            get { return _fuelCapacity; }
            set
            {
                if (value>0 && value<120)
                {
                    _fuelCapacity = value;
                }
                else
                {
                    Console.WriteLine("Wrong value");
                }
                
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length < 100)
                {
                    _model = value.Trim();
                }
            }
        }
        public string Brand {
            get {
                return _brand;
                }
            set 
            {
                if (value.Trim().Length>0 && value.Trim().Length<100)
                {
                    _brand = value.Trim();
                }   
            } 
        }

        public Car(string brand, string model, double fuelCapacity, double fuelFor1Km, int year) : base(year)
        {
            Brand = brand;
            Model = model;
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Year);
            Console.WriteLine(Color);
            Console.WriteLine(Brand);
            Console.WriteLine(Model);
            Console.WriteLine(FuelCapacity);
            Console.WriteLine(FuelFor1Km);
            Console.WriteLine(CurrentFuel);
        }
        public void Drive(float road)
        {
            double tutum = this.FuelCapacity;
            double birKm = this.FuelFor1Km;
            double cariYanacaq = this.CurrentFuel;
            double qaliq;
            if (road <= tutum / birKm && road <= cariYanacaq / birKm)
            {
                qaliq =cariYanacaq-(road * birKm);

                Console.WriteLine(qaliq);
            }
            else
            {
                Console.WriteLine("Masin Bu Qeder Yol Gede Bilmez");
            }
        }
    }
    
}
