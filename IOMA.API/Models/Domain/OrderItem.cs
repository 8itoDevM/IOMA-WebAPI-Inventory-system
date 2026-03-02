namespace IOMA.API.Models.Domain {
    public class OrderItem {
        public Guid Id { get; set; }
        public int Quantitiy { get; set; }
        public double UnitProice { get; set; }

        public Guid ProductId {  get; set; }
        public Guid OrderId { get; set; }
    }
}
