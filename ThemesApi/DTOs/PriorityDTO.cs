using System.ComponentModel.DataAnnotations;

namespace ThemesApi.DTOs
{
    public class PriorityDTO
    {
        [Required]
        public string Title { get; set; }
        public string Color { get; set; }
    }
}
