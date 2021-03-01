namespace ThemesApi.Models
{
    public class Priority
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }

        public Priority(int id, string title, string color)
        {
            this.Id = id;
            this.Title = title;
            this.Color = color;
        }
    }
}