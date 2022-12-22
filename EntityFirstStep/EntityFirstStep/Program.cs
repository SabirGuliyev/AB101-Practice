// See https://aka.ms/new-console-template for more information
using EntityFirstStep.Models;
using EntityFirstStep.Services;



PizzaService pizzaService= new PizzaService();
//pizzaService.CreatePizza("Chicken", 15.20d);

//List<Pizza> pizzas = pizzaService.GetAll();

//foreach (Pizza pizza in pizzas)
//{
//    Console.WriteLine(pizza.Name);
//}

Pizza pizza = pizzaService.GetById(1);
if (pizza == null)
{
    Console.WriteLine("Bele pizza yoxdur");
}
foreach (Size size in pizza.Sizes)
{
    Console.WriteLine(size.Name);
}
//Console.WriteLine(pizza.Name);
//pizzaService.Remove(2);


//Size size = pizzaService.GetSizeById(1);

//Console.WriteLine(size.Pizza.Price);
