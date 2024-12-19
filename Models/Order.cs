namespace CoffeeShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public required string CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
        public List<CoffeeProduct> CoffeeProducts { get; set; } = new List<CoffeeProduct>();
        public decimal TotalAmount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
