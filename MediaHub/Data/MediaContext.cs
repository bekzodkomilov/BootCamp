using mediahub.Entity;
using mediaimage.Entity;
using Microsoft.EntityFrameworkCore;

namespace mediahub.Data
{
        public class MediaContext : DbContext
        {
            public DbSet<MediaImage> Medias { get; set; }
        public object MediaImage { get; internal set; }

        public MediaContext(DbContextOptions options)
                : base(options) { }

            
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<MediaImage>()
                    .HasIndex(g => g.Title)
                    .IsUnique();

            }
        }
}