using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
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

        public ChapterDTO() {
            
        }
    }
}
