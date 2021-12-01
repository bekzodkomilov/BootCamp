using pizza.Entity;
using Microsoft.EntityFrameworkCore;

namespace pizza.Data
{
    public class PizzaDbContext : DbContext
    {
        public DbSet<Pizza_Entity> Pizzas {get; set;}  
        public PizzaDbContext(DbContextOptions options)
            : base(options){}

        protected override void OnModelCreating(ModelBuilder  builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Pizza_Entity>().HasIndex(p => p.ShortName).IsUnique();
        }
        
    }
}                