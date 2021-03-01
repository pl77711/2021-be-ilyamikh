using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThemesApi.DTOs;
using ThemesApi.Models;

namespace ThemesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemeController : Controller
    {

        private readonly IThemeRepository _themeRepository;

        public ThemeController(IThemeRepository context)
        {
            _themeRepository = context;
        }


        // GET: api/Themes
        /// <summary>
        /// Get all themes
        /// </summary>
        /// <returns>array of themes</returns>
        [HttpGet]
        public IEnumerable<Theme> GetAllThemes()
        {
            return _themeRepository.GetAllThemes();
        }

        // GET: api/Themes/2
        /// <summary>
        /// Get theme by id
        /// </summary>
        /// <param name="id">the id of the theme</param>
        /// <returns>The theme</returns>
        [HttpGet("{id}")]
        public ActionResult<Theme> GetTheme(int id)
        {
            return _themeRepository.GetTheme(id);
        }



        // Delete: api/DeleteTheme  
        /// <summary>
        /// Put Theme
        /// </summary>
        /// <param name="id">the id of the theme</param>
        /// <returns>No content</returns>
        [HttpDelete("{id}")]
        public IActionResult DeleteTheme(int id)
        {
            Theme theme = _themeRepository.GetTheme(id);
            if (theme == null)
            {
                return NotFound();
            }
            _themeRepository.Delete(theme);
            _themeRepository.SaveChanges();
            return NoContent();
        }


        // PUT: api/themes/2
        /// <summary>
        /// Modifies a theme
        /// </summary>
        /// <param name="id">id of the theme to be modified</param>
        /// <param name="priority">the modified theme</param>
        [HttpPut("{id}")]
        public IActionResult PutChapter(int id, Theme theme)
        {
            if (id != theme.Id)
            {
                return BadRequest();
            }
            _themeRepository.Update(theme);
            _themeRepository.SaveChanges();
            return NoContent();
        }


        // POST: api/Themes
        /// <summary>
        /// Adds a new theme
        /// </summary>
        /// <param name="theme">the new recipe</param>
        [HttpPost]
        public ActionResult<Theme> PostTheme(ThemeDTO theme)
        {
            Theme newTheme = new Theme() { Title = theme.Title };

            _themeRepository.Add(newTheme);
            _themeRepository.SaveChanges();

            return CreatedAtAction(nameof(GetAllThemes), new { id = newTheme.Id }, newTheme);
        }

    }
}
