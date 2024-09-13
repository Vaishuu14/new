using FirstWebApp_08_22.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp_08_22.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly AppDBContext appDBContext;

        public BooksController(AppDBContext dBContext)
        {

            appDBContext = dBContext;
        }

        [HttpPost("")]
        public async Task<IActionResult> AddData([FromBody] Book book)
        {

            appDBContext.Books.Add(book);
            await appDBContext.SaveChangesAsync();

            return Ok(book);

        }

        [HttpPost("Bulk")]
        public async Task<IActionResult> AddMultiple([FromBody] List<Book> books)
        {
            appDBContext.Books.AddRange(books);
            await appDBContext.SaveChangesAsync();

            return Ok(books);

        }

        [HttpPut("{BookId}")]
        public async Task<IActionResult> updateBook([FromRoute] int BookId, [FromBody] Book model)
        {

            var book = appDBContext.Books.FirstOrDefault(x=> x.Id == BookId);

            if(book == null)
            {
                return NotFound();
            }

            book.Title = model.Title;
            book.Description = model.Description;

            await appDBContext.SaveChangesAsync();

            return Ok(model);

        }


    }
}
