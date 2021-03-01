using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemesApi.Models;

namespace ThemesApi.Data.Repositories
{
    public class ThemeRepository : IThemeRepository
    {

        private readonly ApplicationDbContext _context;

        public ThemeRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Theme theme)
        {
            _context.Themes.Add(theme);
        }

        public void Delete(Theme theme)
        {
            _context.Themes.Remove(theme);
        }

        public IEnumerable<Theme> GetAllThemes()
        {
            return _context.Themes;
        }

        public Theme GetTheme(int id)
        {
            return _context.Themes.Where(e => e.Id == id).FirstOrDefault();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Theme theme)
        {
            _context.Themes.Update(theme);
        }


    }
}
