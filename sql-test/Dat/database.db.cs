using efconsole.Entity;
using Microsoft.EntityFrameworkCore;

namespace efconsole.Data
{
    public class ConsoleDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        
        public ConsoleDbContext(DbContextOptions options)
            : base(options) { }
    }
}