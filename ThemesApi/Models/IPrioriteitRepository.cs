using System.Collections.Generic;

namespace ThemesApi.Models
{
    public interface IPrioriteitRepository
    {
        public IEnumerable<Priority> GetAllPriorities();
        public Priority GetPriority(int id);
        public void Delete(Priority priority);
        public void Update(Priority priority);
        public void SaveChanges();
        public void Add(Priority priority);
    }
}
