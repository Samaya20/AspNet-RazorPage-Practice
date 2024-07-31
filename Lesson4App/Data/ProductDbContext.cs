using Lesson4App.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lesson4App.Data
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext>
            options)
            :base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
