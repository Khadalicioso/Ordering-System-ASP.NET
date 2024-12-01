using IPT_OrderingSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace IPT_OrderingSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define your DbSets for entities, e.g.:
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        // Add other DbSets as necessary
    }
}
