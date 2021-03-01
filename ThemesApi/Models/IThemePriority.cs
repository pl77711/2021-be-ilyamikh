using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.Models
{
    public interface IThemeRepository
    {
        public IEnumerable<Theme> GetAllThemes();
        public Theme GetTheme(int id);
        public void DeleteTheme(Theme theme);
        public void UpdateTheme(Theme Theme);
    }
}
