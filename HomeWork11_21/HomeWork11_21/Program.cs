using HomeWork11_21.Models;

namespace HomeWork11_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW","e39",10,1,1998);

            car.CurrentFuel = 20;
            car.Drive(11);
          
        }
    }
}