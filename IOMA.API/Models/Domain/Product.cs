namespace IOMA.API.Models.Domain {
    public class Product {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }   
        public int Quantity { get; set; }
        public string category { get; set; }
    }
}
