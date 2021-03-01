namespace ThemesApi.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public string Titel { get; set; }

        public Theme(int id, string titel)
        {
            this.Id = id;
            this.Titel = titel;
        }
    }
}