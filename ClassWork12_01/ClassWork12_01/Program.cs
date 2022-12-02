
using ClassWork12_01.Models;
Fruit apple = new Apple { Taste = "Sweet", Water = 20, VitaminA = 40 };
Fruit banana = new Banana { Taste = "Semi-Sweet", Water = 10, VitaminB = 20 };
Fruit orange = new Orange { Taste = "Sour", Water = 120, VitaminC = 140 };

Fruit[] fruits= new Fruit[] { apple, banana, orange };
//Fruit[] fruits1 = { apple, banana, orange };


foreach (var fruit in fruits)
{
    Console.WriteLine($"Taste:{fruit.Taste}\n Fruit kind:{fruit.GetType().Name}\n---------");
}