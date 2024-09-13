using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;
using StudentManagment.Models;

namespace StudentManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public StudentController(AppDBContext DBContext)
        {
            this.appDBContext = DBContext;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddStudents([FromBody] Student student)
        {
            appDBContext.Entrollment.Add(student);
            await appDBContext.SaveChangesAsync();

            return Ok(student);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllStudents()
        {
            var result = await appDBContext.Entrollment.ToListAsync();

            return Ok(result);


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecords([FromRoute] int id, [FromBody] Student student)
        {
            var result = await appDBContext.Entrollment.FirstOrDefaultAsync(x => x.Id == id);

            if (result == null)
            {
                return NotFound();

            }
          
            result.FirstName = student.FirstName ;
            result.LastName = student.LastName ;
            result.Email = student.Email ;

            await appDBContext.SaveChangesAsync();
            return Ok(student);


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudent([FromRoute] int id)
        {
            var result = await appDBContext.Entrollment.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            appDBContext.Entrollment.Remove(result);
             await appDBContext.SaveChangesAsync();

            return Ok("Delete Record Successfully..");

        }

       
    }
}
