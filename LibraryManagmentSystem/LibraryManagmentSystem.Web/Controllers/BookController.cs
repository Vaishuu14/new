using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Queries.BookQueries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Web.Controllers
{
    [Authorize]
    [ApiController]
    [Route("Book")]
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

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            //if (!User.Identity.IsAuthenticated)
            //{
            //    _logger.LogWarning("User is not authenticated.");
            //    return Unauthorized();
            //}

            var books = await _mediator.Send(new GetBooksQuery());
            return View(books);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Add")]
        public async Task<IActionResult> Add(CreateBookCommand command)
        {
            var result = await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return View(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Edit")]
        public async Task<IActionResult> Edit(UpdateBookCommand command)
        {
            var result = await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return View(result);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var command = new DeleteBookCommand(id);
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Member,Admin")]
        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var query = new GetBookByIdQuery(id);
            var result = await _mediator.Send(query);
            return View(result);
        }
    }
}
