using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemesApi.DTOs
{
    public class ThemeDTO
    {
        [Required]
        public string Title { get; set; }
    }
}
