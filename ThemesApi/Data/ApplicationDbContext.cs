using Microsoft.EntityFrameworkCore;
using ThemesApi.Models;

namespace ThemesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<Chapter>().HasOne(e => e.Priority).WithMany().IsRequired(false).HasForeignKey("PriorityId");
            //builder.Entity<Chapter>().HasOne(e => e.Theme).WithOne().IsRequired(false).HasForeignKey("ThemeId");
           builder.Entity<Chapter>().HasOne(e => e.Priority).WithMany().OnDelete(DeleteBehavior.SetNull).IsRequired(false);
           builder.Entity<Chapter>().HasOne(e => e.Theme).WithMany().OnDelete(DeleteBehavior.SetNull).IsRequired(false);
        }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
