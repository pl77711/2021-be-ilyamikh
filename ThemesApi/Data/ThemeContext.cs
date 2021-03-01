using Microsoft.EntityFrameworkCore;
using ThemesApi.Models;

namespace ThemesApi.Data
{
    public class ThemeContext : DbContext
    {
        public ThemeContext(DbContextOptions<ThemeContext> options) 
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Theme>().HasData(
                 new { Id = 1, Title = "Onderzoekstechnieken" },
                 new { Id = 2, Title = "Ontwerpen 3" },
                 new { Id = 3, Title = "Web applicaties 4" },
                 new { Id = 4, Title = "Projecten 2" },
                 new { Id = 5, Title = "Databanken 2" },
                 new { Id = 6, Title = "IT2Talent" },
                 new { Id = 7, Title = "Communication lab" }
            );
            





        }

        public DbSet<Theme> Themes { get; set; }
    }
}
