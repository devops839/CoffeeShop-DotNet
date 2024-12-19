using Microsoft.AspNetCore.Mvc.RazorPages;
using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Pages
{
    public class MenuModel : PageModel
    {
        public required List<CoffeeProduct> CoffeeProducts { get; set; }

        public void OnGet()
        {
            // Simulate fetching coffee products from in-memory database
            CoffeeProducts = new List<CoffeeProduct>
            {
                new CoffeeProduct { Id = 1, Name = "Espresso", Description = "Rich and bold espresso", Price = 3.50m, ImageUrl = "/images/espresso.jpg" },
                new CoffeeProduct { Id = 2, Name = "Cappuccino", Description = "Espresso with frothed milk", Price = 4.00m, ImageUrl = "/images/cappuccino.jpg" }
            };
        }
    }
}
