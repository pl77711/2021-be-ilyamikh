﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
