using account.Entity;
using Microsoft.EntityFrameworkCore;

namespace account.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users {get; set;}
        public ApplicationDbContext(DbContextOptions options)
           : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Phone).IsUnique();
        }


    }
}