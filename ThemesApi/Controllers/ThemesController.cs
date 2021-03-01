using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThemesApi.Models;

namespace ThemesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        private readonly IThemeRepository _themeRepository;

        public ThemesController(IThemeRepository context)
        {
            _themeRepository = context;
        }

        // GET: api/Themes
        /// <summary>
        /// Get all themes
        /// </summary>
        /// <returns>array of themes</returns>
        [HttpGet]
        public IEnumerable<Theme> GetThemes() {
            return _themeRepository.GetThemes();
        }

    }
}
