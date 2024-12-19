using Microsoft.AspNetCore.Mvc.RazorPages;
using CoffeeShop.Models;
using System.Collections.Generic;

namespace CoffeeShop.Pages
{
    public class IndexModel : PageModel
    {
        public required List<CoffeeProduct> FeaturedCoffees { get; set; }

        public void OnGet()
        {
            // Simulate fetching data from the in-memory database
            FeaturedCoffees = new List<CoffeeProduct>
            {
                new CoffeeProduct { Id = 1, Name = "Espresso", Description = "Rich and bold espresso", Price = 3.50m, ImageUrl = "/images/espresso.jpg" },
                new CoffeeProduct { Id = 2, Name = "Cappuccino", Description = "Espresso with frothed milk", Price = 4.00m, ImageUrl = "/images/cappuccino.jpg" }
            };
        }
    }
}
