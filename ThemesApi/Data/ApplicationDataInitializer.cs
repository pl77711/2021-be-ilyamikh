using System;
using ThemesApi.Models;

namespace ThemesApi.Data
{
    public class ApplicationDataInitializer
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDataInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void InitializeData()
        {
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {
                Theme onderzoekstechnieken = new Theme { Title = "Onderzoekstechnieken" };
                Theme ontwerpen = new Theme { Title = "Ontwerpen 3" };
                Theme webapps4 = new Theme { Title = "Web applicaties 4" };
                Theme proj2 = new Theme { Title = "Projecten 2" };
                Theme databanken = new Theme { Title = "Databanken 2" };
                Theme it2talent = new Theme { Title = "IT2Talent" };
                Theme commlab = new Theme { Title = "Communication lab" };
                _context.Themes.Add(onderzoekstechnieken);
                _context.Themes.Add(ontwerpen);
                _context.Themes.Add(webapps4);
                _context.Themes.Add(proj2);
                _context.Themes.Add(databanken);
                _context.Themes.Add(it2talent);
                _context.Themes.Add(commlab);
                _context.SaveChanges();

                Priority p1 = new Priority { Title = "Niet belangerijk", Color = "#e5e5e5" };
                Priority p2 = new Priority { Title = "Beter een keer nazien", Color = "#85D1B2" };
                Priority p3 = new Priority { Title = "Zeker een keer nazien en begrijpen", Color = "#85D1B2" };
                Priority p4 = new Priority { Title = "Zeer belangerijk zeker instuderen", Color = "#F1128D" };
                _context.Priorities.Add(p1);
                _context.Priorities.Add(p2);
                _context.Priorities.Add(p3);
                _context.Priorities.Add(p4);
                _context.SaveChanges();


                Chapter ch1 = new Chapter { Title = "Aan de slag", IsFinished = false, Theme = onderzoekstechnieken, Priority = p1, Date = new DateTime(2020, 9, 1) };
                Chapter ch2 = new Chapter { Title = "Het onderzoeksprocess", IsFinished = false, Theme = onderzoekstechnieken, Priority = p2, Date = new DateTime(2020, 9, 14) };
                Chapter ch3 = new Chapter { Title = "Univaritaire analyse", IsFinished = false, Theme = onderzoekstechnieken, Priority = p3, Date = new DateTime(2020, 10, 1) };
                Chapter ch4 = new Chapter { Title = "De centrale limietstelling", IsFinished = false, Theme = onderzoekstechnieken, Priority = p4, Date = new DateTime(2020, 10, 14) };

                Chapter ch5 = new Chapter { Title = "Introduction", IsFinished = true, Theme = webapps4, Priority = p1, Date = new DateTime(2020, 9, 1) };
                Chapter ch6 = new Chapter { Title = "Angular basics", IsFinished = true, Theme = webapps4, Priority = p2, Date = new DateTime(2020, 9, 14) };
                Chapter ch7 = new Chapter { Title = "Angular sevices", IsFinished = false, Theme = webapps4, Priority = p3, Date = new DateTime(2020, 10, 1) };
                Chapter ch8 = new Chapter { Title = ".Net Core backend API", IsFinished = false, Theme = webapps4, Priority = p4, Date = new DateTime(2020, 10, 14) };

                Chapter ch9 = new Chapter { Title = "Praktische info", IsFinished = false, Theme = databanken, Priority = p1, Date = new DateTime(2020, 9, 1) };
                Chapter ch10 = new Chapter { Title = "SQl Review", IsFinished = true, Theme = databanken, Priority = p2, Date = new DateTime(2020, 9, 14) };
                Chapter ch11 = new Chapter { Title = "SQL Advanced", IsFinished = true, Theme = databanken, Priority = p3, Date = new DateTime(2020, 10, 1) };
                Chapter ch12 = new Chapter { Title = "SQL Advanced2222", IsFinished = true, Theme = databanken, Priority = p3, Date = new DateTime(2020, 10, 2) };
                _context.Chapters.Add(ch1);
                _context.Chapters.Add(ch2);
                _context.Chapters.Add(ch3);
                _context.Chapters.Add(ch4);
                _context.Chapters.Add(ch5);
                _context.Chapters.Add(ch6);
                _context.Chapters.Add(ch7);
                _context.Chapters.Add(ch8);
                _context.Chapters.Add(ch9);
                _context.Chapters.Add(ch10);
                _context.Chapters.Add(ch11);
                _context.Chapters.Add(ch12);
                _context.SaveChanges();
            }
        }
    }
}
