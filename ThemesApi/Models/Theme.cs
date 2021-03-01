using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThemesApi.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
    }
}