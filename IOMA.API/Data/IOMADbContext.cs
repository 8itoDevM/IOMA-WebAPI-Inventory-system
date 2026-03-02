using IOMA.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace IOMA.API.Data {
    public class IOMADbContext : DbContext {
        protected IOMADbContext(DbContextOptions options) : base(options) {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
