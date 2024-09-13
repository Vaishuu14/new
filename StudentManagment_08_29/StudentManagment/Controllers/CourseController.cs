using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;
using StudentManagment.Models;

namespace StudentManagment.Controllers
{
   
        [Route("api/[controller]")]
        [ApiController]
        public class CourseController : ControllerBase
        {
            private readonly AppDBContext _context;

            public CourseController(AppDBContext context)
            {
                _context = context;
            }

            // GET: api/Course
            [HttpGet]
            public async Task<IActionResult> GetCourses()
            {
                var courses = await _context.Courses.ToListAsync();
                return Ok(courses);
            }

            // GET: api/Course/{id}
            [HttpGet("{id}")]
            public async Task<IActionResult> GetCourse(int id)
            {
                var course = await _context.Courses.FindAsync(id);

                if (course == null)
                {
                    return NotFound();
                }

                return Ok(course);
            }

            // POST: api/Course
            [HttpPost]
            public async Task<IActionResult> AddCourse([FromBody] Course course)
            {
                

                _context.Courses.Add(course);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetCourse), new { id = course.Id }, course);
            }

            // PUT: api/Course/{id}
            [HttpPut("{id}")]
            public async Task<IActionResult> UpdateCourse(int id, [FromBody] Course course)
            {
                if (id != course.Id)
                {
                    return BadRequest();
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                _context.Entry(course).State = EntityState.Modified;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return NoContent();
            }

            // DELETE: api/Course/{id}
            [HttpDelete("{id}")]
            public async Task<IActionResult> DeleteCourse(int id)
            {
                var course = await _context.Courses.FindAsync(id);
                if (course == null)
                {
                    return NotFound();
                }

                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool CourseExists(int id)
            {
                return _context.Courses.Any(e => e.Id == id);
            }
        }
    }


