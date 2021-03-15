using System.Collections.Generic;

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
