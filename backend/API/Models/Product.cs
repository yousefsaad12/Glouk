
namespace API.Models
{
    public class Product
    {
        public int productId { get; set;}

        public string Name { get; set;}

        public string ? description { get; set;}
        public string type { get; set;}

        public decimal price { get; set;}
    }
}