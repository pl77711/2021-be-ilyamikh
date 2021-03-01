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
    public class PriorityController : Controller
    {
        private readonly IPrioriteitRepository _priorityRepository;

        public PriorityController(IPrioriteitRepository context)
        {
            _priorityRepository = context;
        }

        // GET: api/Priorities
        /// <summary>
        /// Get all priorities
        /// </summary>
        /// <returns>array of priorities</returns>
        [HttpGet]
        public IEnumerable<Priority> GetAllPriorities()
        {
            return _priorityRepository.GetAllPriorities();
        }


        // GET: api/priority/2
        /// <summary>
        /// Get priority by id
        /// </summary>
        /// <param name="id">the id of the priority</param>
        /// <returns>The priority</returns>
        [HttpGet("{id}")]
        public ActionResult<Priority> GetPriority(int id)
        {
            return _priorityRepository.GetPriority(id);
        }

        // DELETE: api/priorities/5
        /// <summary>
        /// Deletes a recipe
        /// </summary>
        /// <param name="id">the id of the recipe to be deleted</param>
        [HttpDelete("{id}")]
        public IActionResult DeletePriority(int id)
        {
            Priority priority = _priorityRepository.GetPriority(id);
            if (priority == null)
            {
                return NotFound();
            }
            _priorityRepository.Delete(priority);
            _priorityRepository.SaveChanges();
            return NoContent();
        }

        // PUT: api/priorities/2
        /// <summary>
        /// Modifies a priority
        /// </summary>
        /// <param name="id">id of the priority to be modified</param>
        /// <param name="priority">the modified pruirity</param>
        [HttpPut("{id}")]
        public IActionResult PutChapter(int id, Priority priority)
        {
            if (id != priority.Id)
            {
                return BadRequest();
            }
            _priorityRepository.Update(priority);
            _priorityRepository.SaveChanges();
            return NoContent();
        }


        // POST: api/priorities
        /// <summary>
        /// Adds a new priority
        /// </summary>
        /// <param name="priority">the new priority</param>
        [HttpPost]
        public ActionResult<Priority> PostPriority(PriorityDTO priority)
        {
            Priority newPriority = new Priority() { Title = priority.Title, Color = priority.Color };
            _priorityRepository.Add(newPriority);
            _priorityRepository.SaveChanges();

            return CreatedAtAction(nameof(GetAllPriorities), new { id = newPriority.Id }, newPriority);
        }
    }
}
