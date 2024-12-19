namespace CoffeeShop.Models
{
    public class CoffeeProduct
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }  // URL to an image of the coffee
    }
}
