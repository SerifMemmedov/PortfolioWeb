using Microsoft.EntityFrameworkCore;

namespace PortfolioWeb.Models
{
    public class PortfolioDbContext:DbContext
    {
        public PortfolioDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Section1> section1s { get; set; }
    }
}
