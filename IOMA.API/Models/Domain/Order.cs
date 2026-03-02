namespace IOMA.API.Models.Domain {
    public class Order {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Status { get; set; }

        public Guid UserId { get; set; }
    }
}
