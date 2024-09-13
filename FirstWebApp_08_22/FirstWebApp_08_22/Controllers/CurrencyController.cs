using FirstWebApp_08_22.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp_08_22.Controllers
{
  
    [Route("api/Currencies")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {

        private readonly AppDBContext _dbContext;
        public CurrencyController(AppDBContext appDB)
        {
            this._dbContext = appDB;

        }

        //using simple method to get multiple records

        //[HttpGet("")]
        //public IActionResult GetAllCurrencies()
        //{
        //    var result = _dbContext.Currencies.ToList();

        //    return Ok(result);
        //}



        //using async method to get multiple records

        [HttpGet("")]
        public async Task<IActionResult> GetAllCurrencies()
        {
            var result = await _dbContext.Currencies.ToListAsync();

            return Ok(result);
        }



        //using async to get single record


        [HttpGet("{Id:int}")]

        public async Task<IActionResult> GetDataByID([FromRoute] int Id)
        {
            var result = await _dbContext.Currencies.FindAsync(Id);
            return Ok(result);
        }

        //using FirstAsunc() for getting data

        [HttpGet("{name}")]
        public async Task<IActionResult> GetData([FromRoute] string name)
        {

            var result = await _dbContext.Currencies.Where(x => x.Title == name).FirstAsync();
            return Ok(result);

        }

        // Get records based on IDs

        //[HttpPost("all")]
        //public async Task<IActionResult> GetByIds([FromBody] List<int> ids)
        //{
        //    var result = await _dbContext.Currencies.Where(x=>ids.Contains(x.Id)).ToListAsync();
        //    return Ok(result);
        //}

        // Select specific column 

        [HttpPost("all")]
        public async Task<IActionResult> GetSpecificColumn([FromBody] List<int> ids)
        {

            var result = await _dbContext.Currencies
                .Where(x => ids.Contains(x.Id))
                .Select(x => new Currency
                {
                    Id = x.Id,
                    Title = x.Title,
                })
                .ToListAsync();

            return Ok(result);
        }


    }
}
