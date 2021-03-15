using System.ComponentModel.DataAnnotations;

namespace ThemesApi.DTOs
{
    public class ThemeDTO
    {
        [Required]
        public string Title { get; set; }
    }
}
