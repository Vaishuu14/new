using EmployeeManagment.Models;
using EmployeeManagment.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public EmployeeController(AppDBContext dBContext)
        {
            appDBContext = dBContext;

        }

        [HttpGet]
        public async Task<IActionResult> GetEmployees()
        {
            var result = await appDBContext.Employees.ToListAsync();

            return Ok(result);

        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmpById([FromRoute] int id)
        {
            var result = await appDBContext.Employees.FindAsync(id);

            return Ok(result);
        }

        [HttpGet("{name:alpha}")]
        public async Task<IActionResult> GetEmpByName([FromRoute] string name)
        {
            var result = await appDBContext.Employees
                .Where(x => x.Name == name)
                .SingleOrDefaultAsync();

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddRecords([FromBody] Employee emp)
        {

            appDBContext.Employees.Add(emp);
            await appDBContext.SaveChangesAsync();

            return Ok(emp);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRecords([FromRoute] int id, [FromBody] Employee emp)
        {
            var result = await appDBContext.Employees.FirstOrDefaultAsync(x => x.ID == id);

            if (result == null)
            {
                return NotFound(); 
            }

           
            result.Name = emp.Name;
            result.Phone = emp.Phone;
            result.Email = emp.Email;

            
            await appDBContext.SaveChangesAsync();

            return Ok(result); 
        }


        [HttpDelete("{eid:int}")]
        public async Task<IActionResult> DeleteRecords([FromRoute] int eid)
        {
          var result = await appDBContext.Employees.FindAsync(eid);

            if(result == null)
            {
                return NotFound();
            }

             appDBContext.Employees.Remove(result);
            await appDBContext.SaveChangesAsync();

            return Ok("Delete Record Successfully..");

        }

        



    }
}
