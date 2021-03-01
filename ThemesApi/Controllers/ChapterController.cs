using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ThemesApi.DTOs;
using ThemesApi.Models;

namespace ThemesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        private readonly IChapterRepository _chapterRepository;

        public ChapterController(IChapterRepository context)
        {
            _chapterRepository = context;
        }     

        // GET: api/Chapter/2
        /// <summary>
        /// Get the chapter by id
        /// </summary>
        /// <param name="id">the id of the chapter</param>
        /// <returns>The chapter</returns>
        [HttpGet("{id}")]
        public ActionResult<Chapter> GetChapterById(int id)
        {
            return _chapterRepository.GetChapterById(id);
        }

        // GET: api/Chapters
        /// <summary>
        /// Get all chapters by theme id or priority id
        /// </summary>
        /// <param name="themeId">the id of the Theme</param>
        /// <param name="prioId">the id of the Theme</param>
        /// <returns>array of chapters by theme or priority or apply or filter by priority AND theme, if no parameters provided returns list of all chapters</returns>
        [HttpGet]
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
        /*
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
        */
        // Delete: api/DeleteChapter    
        /// <summary>
        /// Put Chapter
        /// </summary>
        /// <param name="id">the id of the chapter</param>
        /// <returns>No content</returns>
        [HttpDelete("{id}")]
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



        // PUT: api/chapters/2
        /// <summary>
        /// Modifies a chapter
        /// </summary>
        /// <param name="id">id of the chapter to be modified</param>
        /// <param name="chapter">the modified chapter</param>
        [HttpPut("{id}")]
        public IActionResult PutChapter(int id, Chapter chapter)
        {
            if (id != chapter.Id)
            {
                return BadRequest();
            }
            _chapterRepository.Update(chapter);
            _chapterRepository.SaveChanges();
            return NoContent();
        }


        // POST: api/chapters
        /// <summary>
        /// Adds a new chapter
        /// </summary>
        /// <param name="chapter">the new chapter</param>
        [HttpPost]
        public ActionResult<Priority> PostChapter(ChapterDTO chapter)
        {

            Priority priority = _chapterRepository.getPriorityById(chapter.Priority.Id);
            Theme theme = _chapterRepository.getThemeById(chapter.Theme.Id);

            Chapter newChapter = new Chapter() {
                Title = chapter.Title,
                Priority = priority,
                Theme = theme,
            };
            _chapterRepository.Add(newChapter);
            _chapterRepository.SaveChanges();

            return CreatedAtAction(nameof(GetAllChaptersByThemeOrPriority), new { id = newChapter.Id }, newChapter);
        }

    }
}
