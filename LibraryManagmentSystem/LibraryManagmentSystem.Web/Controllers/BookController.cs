using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Queries.BookQueries;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Web.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("Book")]
    public class BookController : Controller
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

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var books = await _mediator.Send(new GetBooksQuery());
            return PartialView("Index", books);  
        }


        // [Authorize(Roles = "Admin")]
        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View();
        }

        // [Authorize(Roles = "Admin")]
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromForm] CreateBookCommand command)
        {
            if (!ModelState.IsValid)
            {
                // Return the view with validation errors if model state is invalid
                return View(command);
            }

            var result = await _mediator.Send(command);
            return RedirectToAction("Index");
        }



        // [Authorize(Roles = "Admin")]
        // GET: /Book/Edit/5
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var bookDto = await _bookService.GetByIdAsync(id);
           // var bookDto = await _mediator.Send(query);

            if (bookDto == null)
            {
                return NotFound();
            }

            var updateBookCommand = _mapper.Map<UpdateBookCommand>(bookDto);
            return View(updateBookCommand);
        }

        // POST: /Book/Edit
        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(UpdateBookCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }



        // [Authorize(Roles = "Admin")]
        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return View(result);
        }

        //[Authorize(Roles = "Admin")]
        [HttpPost("Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var command = new DeleteBookCommand(id);
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        //[Authorize(Roles = "Member,Admin")]
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return View(result);
        }
    }
}
