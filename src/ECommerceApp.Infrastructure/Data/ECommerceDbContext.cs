using Microsoft.EntityFrameworkCore;
using ECommerceApp.Core.Entities;

namespace ECommerceApp.Infrastructure.Data
{
    public class ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
