using Microsoft.EntityFrameworkCore;

namespace StocScreenerCoreApp.Data
{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Stock> Stocks { get; set; }
    }
}
