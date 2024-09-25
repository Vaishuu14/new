using AutoMapper;
using LibraryManagmentSystem.Application.Commands.ReservationCommands;
using LibraryManagmentSystem.Application.Queries.ReservationQueries;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IReservationRepository _reservationService;

        public ReservationController(IMediator mediator, IMapper mapper, IReservationRepository reservationService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _reservationService = reservationService;
        }

        [HttpGet]
        [Route("/reservation/list")]
        public async Task<IActionResult> ReservationList()
        {
            var reservations = await _mediator.Send(new GetReservationsQuery());
            return Ok(reservations);
        }

        [HttpGet]
        [Route("/reservation/details")]
        public async Task<IActionResult> Details(int id)
        {
            var query = new GetReservationByIdQuery(id);
            var result = await _mediator.Send(query);
            if (result == null)
            {

                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("/reservation/create")]
        public async Task<IActionResult> CreateReservation([FromForm] CreateReservationCommand command)
        {
            if (!ModelState.IsValid)
            {
                // Return the view with validation errors if model state is invalid
                return Ok(command);
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("/reservation/update")]
        public async Task<IActionResult> Edit(UpdateReservationCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return Ok(command);
        }

        [HttpDelete]
        [Route("/reservation/delete")]
        public async Task<IActionResult> DeleteMember(int id)
        {
            var command = new CancelReservationCommand { Id = id };
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}
