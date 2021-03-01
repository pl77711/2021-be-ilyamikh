using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.Models
{
    public class Chapter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsFinished { get; set; }
        public Priority? Priority { get; set; }
        public Theme? Theme { get; set; }
        public DateTime? Date { get; set; }

        public Chapter(int id, string title, bool isFinished, Priority? priority = null, Theme? theme = null, DateTime? date = null)
        {
            this.Id = id;
            this.Title = title;
            this.IsFinished = isFinished;
            this.Priority = priority;
            this.Theme = theme;
            this.Date = date;
        }
    }
}
