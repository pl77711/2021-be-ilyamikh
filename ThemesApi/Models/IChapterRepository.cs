﻿using System.Collections.Generic;

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

        public Priority getPriorityById(int id);
        public Theme getThemeById(int id);

        public void Add(Chapter chapter);
        public void SaveChanges();

    }
}
