using accounts.Entity;
using Microsoft.EntityFrameworkCore;

namespace accounts.Data
{
    public class ApplacationDbcontext : DbContext
    {   
        public DbSet<User> Users {get ; set;}
        public ApplacationDbcontext(DbContextOptions option) 
        : base(option) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Phone).IsUnique();
        }
    }
}