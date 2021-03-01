using Microsoft.EntityFrameworkCore;
using System;
using ThemesApi.Models;

namespace ThemesApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
    }
}
