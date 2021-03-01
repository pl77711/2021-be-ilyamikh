using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThemesApi.Models;

namespace ThemesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        private readonly IChapterRepository _chapterRepository;

        public ThemesController(IChapterRepository context)
        {
            _chapterRepository = context;
        }

        // GET: api/Themes
        /// <summary>
        /// Get all themes
        /// </summary>
        /// <returns>array of themes</returns>
        [HttpGet("/themes")]
        public IEnumerable<Theme> GetAllThemes() {
            return _chapterRepository.GetAllThemes();
        }

        // GET: api/Priorities
        /// <summary>
        /// Get all priorities
        /// </summary>
        /// <returns>array of priorities</returns>
        [HttpGet("/priorities")]
        public IEnumerable<Priority> GetAllPriorities()
        {
            return _chapterRepository.GetAllPriorities();
        }

        // GET: api/Chapter/2
        /// <summary>
        /// Get the chapter by id
        /// </summary>
        /// <param name="chapterId">the id of the chapter</param>
        /// <returns>The chapter</returns>
        [HttpGet("/chapters/{chapterId}")]
        public ActionResult<Chapter> GetChapterById(int chapterId)
        {
            return _chapterRepository.GetChapterById(chapterId);
        }

        // GET: api/Chapters
        /// <summary>
        /// Get all chapters by theme id or priority id
        /// </summary>
        /// <param name="themeId">the id of the Theme</param>
        /// <param name="prioId">the id of the Theme</param>
        /// <returns>array of chapters by theme or priority or apply or filter by priority AND theme, if no parameters provided returns list of all chapters</returns>
        [HttpGet("/chapters")]
        public IEnumerable<Chapter> GetAllChaptersByThemeOrPriority(int? themeId, int? prioId)
        {                
            if (themeId.HasValue && prioId.HasValue) 
                    return _chapterRepository.GetAllChaptersByPriorityAndTheme(themeId.Value, prioId.Value);
            if (themeId.HasValue && (!prioId.HasValue)) 
                return _chapterRepository.GetAllChaptersByTheme(themeId.Value);
            if ((!themeId.HasValue) && prioId.HasValue)
                return _chapterRepository.GetAllChaptersByPriority(prioId.Value);
            else
                return _chapterRepository.GetAllChapters();

        }

        // GET: api/Chapters
        /// <summary>
        /// Get all chapters by priority 
        /// </summary>
        /// <param name="prioId">the id of the priority</param>
        /// <returns>array of chapters by  priority</returns>
        [HttpGet("/chaptersbyprio")]
        public IEnumerable<Chapter> GetAllChaptersByPriority(int? prioId)
        {
            if (prioId.HasValue) return _chapterRepository.GetAllChaptersByPriority(prioId.Value);
            else return _chapterRepository.GetAllChapters();
        }

        // GET: api/Chapters
        /// <summary>
        /// Get all chapters by theme 
        /// </summary>
        /// <param name="themeId">the id of the Theme</param>
        /// <returns>array of chapters by  priority</returns>
        [HttpGet("/chaptersbytheme")]
        public IEnumerable<Chapter> GetAllChaptersByTheme(int? themeId)
        {
            if (themeId.HasValue) return _chapterRepository.GetAllChaptersByTheme(themeId.Value);
            else return _chapterRepository.GetAllChapters();

        }

        // Delete: api/DeleteChapter    
        /// <summary>
        /// Put Chapter
        /// </summary>
        /// <param name="id">the id of the chapter</param>
        /// <returns>No content</returns>
        [HttpDelete("/chapter/{id}")]
        public IActionResult DeleteChapter(int id)
        {
            Chapter chapter = _chapterRepository.GetChapterById(id);
            if (chapter == null)
            {
                return NotFound();
            }
            _chapterRepository.Delete(chapter);
            _chapterRepository.SaveChanges();
            return NoContent();
        }
    }
}
