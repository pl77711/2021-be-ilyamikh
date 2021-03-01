using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.Models
{
    public interface IThemeRepository
    {
        public IEnumerable<Theme> GetThemes();
    }
}
