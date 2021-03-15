using System.Collections.Generic;
using System.Linq;
using ThemesApi.Models;

namespace ThemesApi.Data.Repositories
{
    public class PriorityRepository : IPrioriteitRepository
    {
        private readonly ApplicationDbContext _context;

        public PriorityRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }

        public void Add(Priority priority)
        {
            _context.Priorities.Add(priority);
        }

        public void Delete(Priority priority)
        {
            _context.Priorities.Remove(priority);
        }

        public IEnumerable<Priority> GetAllPriorities()
        {
            return _context.Priorities;
        }

        public Priority GetPriority(int id)
        {
            return _context.Priorities.Where(e => e.Id == id).SingleOrDefault();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(Priority priority)
        {
            _context.Update(priority);
        }
    }
}
