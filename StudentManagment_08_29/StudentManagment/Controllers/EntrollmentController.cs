using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Data;
using StudentManagment.Models;
using System;

namespace StudentManagment.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public EnrollmentController(AppDBContext context)
        {
            appDBContext = context;
        }

        [HttpPost]
        public async Task<IActionResult> AddEnrollment([FromBody] Entrollment enrollment)
        {
            appDBContext.Entrollments.Add(enrollment);
            await appDBContext.SaveChangesAsync();

            return Ok(enrollment);
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await appDBContext.Entrollment.ToListAsync();

            return Ok(result);


        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEnrollment([FromRoute] int id, [FromBody] Entrollment enrollment)
        {
            var existingEnrollment = await appDBContext.Entrollments.FirstOrDefaultAsync(x => x.Id == id);

            if (existingEnrollment == null)
            {
                return NotFound();
            }

            // Update the fields of the existing enrollment
            existingEnrollment.StudentId = enrollment.StudentId;
            existingEnrollment.CourseId = enrollment.CourseId;
            existingEnrollment.EnrollmentDate = enrollment.EnrollmentDate;

            await appDBContext.SaveChangesAsync();

            return Ok(existingEnrollment);
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
