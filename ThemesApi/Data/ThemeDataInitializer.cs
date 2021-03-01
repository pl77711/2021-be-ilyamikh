namespace ThemesApi.Data
{
    public class ThemeDataInitializer
    {
        private readonly ThemeContext _context;

        public ThemeDataInitializer(ThemeContext context)
        {
            _context = context;
        }

        public void InitializeData()
        {
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {
                //seeding the database with themes, see DBContext               
            }
        }
    }
}
