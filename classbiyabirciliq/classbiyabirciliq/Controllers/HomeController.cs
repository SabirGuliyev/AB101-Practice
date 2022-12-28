using classbiyabirciliq.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace classbiyabirciliq.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name="C Nike",
                    Image="product-2.jpg"
                },
                 new Product
                {
                    Id = 2,
                    Name="B Nike",
                    Image="product-1.jpg"
                },
                  new Product
                {
                    Id = 3,
                    Name="A Nike",
                    Image="product-3.jpg"
                }
            };
            return View(products);
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
