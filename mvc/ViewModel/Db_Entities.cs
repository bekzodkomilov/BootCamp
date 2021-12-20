using Microsoft.EntityFrameworkCore;

namespace ProjectMVC5.Models
{
    public class DB_Entities: DbContext
    { 
        public DbSet<User> Users { get; set; }

        public DB_Entities(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(g => g.Email)
                .IsUnique();
        }
    }
}
