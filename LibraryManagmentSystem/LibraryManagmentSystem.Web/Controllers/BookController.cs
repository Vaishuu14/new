using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.Queries;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Queries.BookQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;
using System;
using Microsoft.AspNetCore.Http.HttpResults;
using static System.Collections.Specialized.BitVector32;


namespace LibraryManagmentSystem.Web.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly ILogger<BookController> _logger;

        public BookController(IMediator mediator, IMapper mapper, ILogger<BookController> logger)
        {
            _mediator = mediator;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _mediator.Send(new GetBooksQuery());
            return View(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateBookCommand command)
        {
            var result = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetBookById), new { id = result.Id }, result);
        }


        // Update an existing book
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] UpdateBookCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("ID in URL does not match ID in body.");
            }

            var result = await _mediator.Send(command);
            return result != null ? Ok(result) : NotFound();
        }

        // Delete a book
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var command = new DeleteBookCommand(id);
            await _mediator.Send(command);
            return NoContent(); // Return 204 No Content if the delete is successful
        }

        // Get all books 
        //[HttpGet]
        //public async Task<IActionResult> GetAllBooks()
        //{
        //    var query = new GetBooksQuery();
        //    var result = await _mediator.Send(query);
        //    return Ok(result);
        //}
    }
}

//             <th>Actions</th>

//< td >
//        < a asp - controller = "BookDto" asp - action = "GetBookById" asp - route - id = "@book.Id" class= "btn btn-info" > Details </ a >
//        < a asp - controller = "BookDto" asp - action = "UpdateBook" asp - route - id = "@book.Id" class= "btn btn-warning" > Edit </ a >
//        < a asp - controller = "BookDto" asp - action = "DeleteBook" asp - route - id = "@book.Id" class= "btn btn-danger" > Delete </ a >
//</ td >


//< a asp - controller = "Book" asp - action = "CreateBook" class= "btn btn-primary" > Create New Book</a>
