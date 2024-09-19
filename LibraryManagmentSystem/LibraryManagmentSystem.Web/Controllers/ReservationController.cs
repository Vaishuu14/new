using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.DTOs;
using LibraryManagmentSystem.Application.Queries;
using LibraryManagmentSystem.Application.Commands.ReservationCommands;
using LibraryManagmentSystem.Application.Queries.ReservationQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Domain.Entities;

[Route("[controller]")]
public class ReservationController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    private readonly IReservationRepository _reservationrepo;

    public ReservationController(IMediator mediator, IMapper mapper , IReservationRepository reservationrepo)
    {
        _mediator = mediator;
        _mapper = mapper;
        _reservationrepo = reservationrepo;
    }

    [HttpGet("")]
    public async Task<IActionResult> Index()
    {
        var reservations = await _mediator.Send(new GetReservationsQuery());
        return View(reservations);
    }

    public async Task<IActionResult> Create()
    {
        // Return the view with an empty CreateReservationCommand model
        return View(new CreateReservationCommand());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CreateReservationCommand command)
    {
        if (ModelState.IsValid)
        {
            var reservation = _mapper.Map<Reservation>(command);
            await _reservationrepo.AddReservationAsync(reservation);
            return RedirectToAction(nameof(Index));
        }

        // Log or inspect validation errors
        foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
        {
            // Log error.ErrorMessage or use a breakpoint
        }

        return View(command);
    }


    [HttpGet("Edit/{id}")]
    public async Task<IActionResult> Edit(int id)
    {
        var reservation = await _mediator.Send(new GetReservationByIdQuery(id));
        if (reservation == null)
        {
            return NotFound();
        }
        var reservationDto = _mapper.Map<UpdateReservationCommand>(reservation);
        return View(reservationDto);
    }

    [HttpPost("Edit/{id}")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, UpdateReservationCommand reservationDto)
    {
        if (id != reservationDto.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            var command = _mapper.Map<UpdateReservationCommand>(reservationDto);
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
        return View(reservationDto);
    }


    [HttpGet("Details/{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var reservation = await _mediator.Send(new GetReservationByIdQuery(id));
        if (reservation == null)
        {
            return NotFound();
        }
        return View(reservation);
    }
}
