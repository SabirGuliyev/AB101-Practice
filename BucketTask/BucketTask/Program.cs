using BucketTask.Models;
namespace BucketTask
{
    class Program
    {
        static void Main()
        {
            Flower tulip = new Flower
            {
                Name = "Tulip",
                Color = "white",
                Price = 1.9f
            };
            Flower rose = new Flower
            {
                Name = "Rose",
                Color = "red",
                Price = 3f
            };

            Bucket bucket = new Bucket();
            bucket.DiscountPercent = 0;

            var result = bucket.TotalPrice();
            if (result.HasFlower)
            {
                Console.WriteLine(result.Price);
            }
            else
            {
                Console.WriteLine("Buketde gul yoxdur, ay kasib");
            }
            bucket.AddFlower(rose);
            bucket.AddFlower(rose);
            bucket.AddFlower(tulip);
            bucket.AddFlower(rose);
            result = bucket.TotalPrice();
            if (result.HasFlower)
            {
                Console.WriteLine(result.Price);
            }
            else
            {
                Console.WriteLine("Buketde gul yoxdur, ay kasib");
            }
        }
    }
}