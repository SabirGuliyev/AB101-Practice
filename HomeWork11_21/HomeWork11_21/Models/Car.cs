using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork11_21.Models
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

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
