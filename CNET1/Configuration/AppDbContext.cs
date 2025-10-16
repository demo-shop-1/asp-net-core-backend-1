using CNET1.Features.Products.Adapters.Entity;
using Microsoft.EntityFrameworkCore;

namespace CNET1.Configuration
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<ProductEntity> Products { get; set; }
    }
}
