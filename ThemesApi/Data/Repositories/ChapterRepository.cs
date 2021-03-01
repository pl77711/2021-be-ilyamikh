using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using ThemesApi.Models;

namespace ThemesApi.Data.Repositories
{
    public class ChapterRepository : IChapterRepository
    {

        private readonly ApplicationDbContext _context;

        public ChapterRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Chapter> GetAllChapters()
        {
            return _context.Chapters.Include(e => e.Priority).Include(e => e.Theme).ToList();
        }

        public Chapter GetChapterById(int id)
        {
            return _context.Chapters.Where(e => e.Id == id).Include(e => e.Priority).Include(e => e.Theme).FirstOrDefault();
        }

        public IEnumerable<Chapter> GetAllChaptersByPriority(int prioId)
        {
            return _context.Chapters.Where(e => e.Priority.Id == prioId).Include(e => e.Priority).Include(e => e.Theme).ToList();
        }

        public IEnumerable<Chapter> GetAllChaptersByTheme(int themeId)
        {
            return _context.Chapters.Where(e => e.Theme.Id == themeId).Include(e => e.Priority).Include(e => e.Theme).ToList();
        }

        public IEnumerable<Chapter> GetAllChaptersByPriorityAndTheme(int? themeId, int? prioId)
        {
            return _context.Chapters.Where(e => e.Theme.Id == themeId && e.Priority.Id == prioId).Include(e => e.Priority).Include(e => e.Theme).ToList();
        }

        public void Delete(Chapter chapter)
        {
            _context.Chapters.Remove(chapter);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Chapter chapter)
        {
            _context.Chapters.Update(chapter);
        }

        public void Add(Chapter chapter)
        {
            _context.Chapters.Add(chapter);
        }

        public Priority getPriorityById(int id)
        {
            return _context.Priorities.Where(e => e.Id == id).FirstOrDefault();
        }

        public Theme getThemeById(int id)
        {
            return _context.Themes.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}
