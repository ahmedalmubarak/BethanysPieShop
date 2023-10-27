using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class BethanyPieShopDbContext : DbContext
    {
        public BethanyPieShopDbContext(DbContextOptions<BethanyPieShopDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Pie> Pies { get; set; }
    }
}
