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
        public void Delete(Theme theme);
        public void Update(Theme Theme);
        public void SaveChanges();
        void Add(Theme theme);
    }
}
