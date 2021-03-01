using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.Models
{
    public interface IChapterRepository
    {
        public IEnumerable<Chapter> GetAllChapters();
        public Chapter GetChapterById(int id);
        public IEnumerable<Chapter> GetAllChaptersByPriorityAndTheme(int? themeId, int? prioId);
        public IEnumerable<Chapter> GetAllChaptersByPriority(int prioId);
        public IEnumerable<Chapter> GetAllChaptersByTheme(int themeId);
        public void Delete(Chapter chapter);
        public void Update(Chapter chapter);
        public void Add(Chapter chapter);
        public void SaveChanges();

    }
}
