using System;

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

        public Chapter()
        {
            IsFinished = false;
        }
    }
}
