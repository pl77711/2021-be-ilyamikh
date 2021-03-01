using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.Models
{
    public interface IPrioriteitRepository
    {
        public IEnumerable<Priority> GetAllPriorities();
        public Priority GetPrioriry(int id);
        public void DeletePriority(Priority priority);
        public void UpdatePrioroty(Priority priority);
    }
}
