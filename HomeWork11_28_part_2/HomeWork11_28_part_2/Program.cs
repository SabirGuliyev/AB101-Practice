using HomeWork11_28_part_2.Models;

namespace HomeWork11_28_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane
            {
                Path =200,
                Time=1,
                CurrentOil = 2,
                OilCapacity = 5,
                OilType = "Premium",
                WingLength =5
            };

            plane.AverageSpeed();
            plane.RemainOilAmount();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"Path:{plane.Path}\nTime:{plane.Time}\n" +
                $"CurrentOil:{plane.CurrentOil}\nOilCapacity:{plane.OilCapacity}\n" +
                $"OilType:{plane.OilType}\nWingLength:{plane.WingLength}");
        }
    }
}