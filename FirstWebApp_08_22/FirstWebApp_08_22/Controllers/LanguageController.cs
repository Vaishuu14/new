using FirstWebApp_08_22.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp_08_22.Controllers
{
    [Route("api/Languages")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDBContext _dbContext;

        public LanguageController(AppDBContext appDBContext)
        {
         
            _dbContext = appDBContext;
            
        }

        // using async to get multiple record


        //[HttpGet("")]
        //public  IActionResult GetResult()
        //{
        //    var result =  _dbContext.Languages.ToList();

        //    return Ok(result);

        //}


        // using async to get multiple record

        [HttpGet("")]
        public async Task<IActionResult> GetResult()
        {
            var result = await _dbContext.Languages.ToListAsync();

            return Ok(result);

        }

        //using async to get single record

        [HttpGet("{Id}")]

        public async Task<IActionResult> GetDataById([FromRoute] int Id)
        {
            var Result = await _dbContext.Languages.FindAsync(Id);

            return Ok(Result);
        }



    }
}
