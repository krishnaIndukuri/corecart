using corecart.Models;
using Microsoft.EntityFrameworkCore;

namespace corecart.Data
{
    public class SqlDbContext: DbContext
    {
        public SqlDbContext(DbContextOptions options):base(options)
        { }
        public DbSet<Restaurant> resturants { get; set; }
    }
}
