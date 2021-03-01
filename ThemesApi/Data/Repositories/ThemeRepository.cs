using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ThemesApi.Models;

namespace ThemesApi.Data.Repositories
{
    public class ThemeRepository : IThemeRepository
    {

        private readonly ThemeContext _context;
        private readonly DbSet<Theme> _themes;

        public ThemeRepository(ThemeContext dbContext)
        {
            _context = dbContext;
            _themes = dbContext.Themes;
        }

        public IEnumerable<Theme> GetThemes()
        {
            return _themes.ToList();
        }
    }
}
