namespace ThemesApi.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public Theme(int id, string title)
        {
            this.Id = id;
            this.Title = title;
        }
    }
}