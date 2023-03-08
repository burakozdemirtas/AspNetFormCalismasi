using Microsoft.EntityFrameworkCore;

namespace denemesql.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Fiyatlar> Fiyatlar { get; set; }
    }

}
