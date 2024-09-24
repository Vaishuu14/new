using AutoMapper;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Queries.BookQueries;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookService;

        public BookController(IMediator mediator, IMapper mapper, IBookRepository bookService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _bookService = bookService;
        }

        [HttpGet]
        [Route("/book/list")]
        public async Task<IActionResult> GetBooks()
        {
            var books = await _mediator.Send(new GetBooksQuery());
            return Ok(books);
        }

        [HttpGet]
        [Route("/book/details")]
        public async Task<IActionResult> DetailsOfBook(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound(); // Return NotFound if the book doesn't exist
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("/book/create")]
        public async Task<IActionResult> CreateBook([FromForm] CreateBookCommand command)
        {
            if (!ModelState.IsValid)
            {
                // Return the view with validation errors if model state is invalid
                return Ok(command);
            }

            var result = await _mediator.Send(command);
           return Ok(result);
           
        }

        // POST: /Book/Edit
        [HttpPut]
        [Route("/book/update")]
        public async Task<IActionResult> EditBook(UpdateBookCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return Ok(command);
        }

       

        [HttpDelete]
        [Route("/book/delete")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var command = new DeleteBookCommand(id);
            await _mediator.Send(command);
            return Ok(command);
        }
    }
}
