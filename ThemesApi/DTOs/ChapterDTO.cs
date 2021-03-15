using System;
using System.ComponentModel.DataAnnotations;
using ThemesApi.Models;

namespace ThemesApi.DTOs
{
    public class ChapterDTO
    {
        [Required]
        public string Title { get; set; }
        public Priority? Priority { get; set; }
        public Theme? Theme { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }

        public ChapterDTO()
        {

        }
    }
}
