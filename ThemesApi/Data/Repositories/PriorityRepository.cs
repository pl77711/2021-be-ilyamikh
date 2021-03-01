using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void DeletePriority(Priority priority)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Priority> GetAllPriorities()
        {
            throw new NotImplementedException();
        }

        public Priority GetPrioriry(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePrioroty(Priority priority)
        {
            throw new NotImplementedException();
        }
    }
}
