using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.Commands.MemberCommands;
using LibraryManagmentSystem.Application.Queries;
using LibraryManagmentSystem.Application.Queries.MemberQueries;
using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Web.Controllers
{
    [Authorize(Roles = "Admin")] // Ensure only Admins can access this controller
    public class MemberController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MemberController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        // GET: /Member
        public async Task<IActionResult> Index()
        {
            var query = new GetMembersQuery();
            var members = await _mediator.Send(query);
            var memberViewModels = _mapper.Map<IEnumerable<Member>>(members);
            return View(memberViewModels);
        }

        // GET: /Member/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var query = new GetMemberByIdQuery(id);
            var member = await _mediator.Send(query);
            if (member == null)
            {
                return NotFound();
            }
            var memberViewModel = _mapper.Map<Member>(member);
            return View(memberViewModel);
        }

        // GET: /Member/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Member/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Member model)
        {
            if (ModelState.IsValid)
            {
                var command = _mapper.Map<CreateMemberCommand>(model);
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: /Member/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var query = new GetMemberByIdQuery(id);
            var member = await _mediator.Send(query);
            if (member == null)
            {
                return NotFound();
            }
            var memberViewModel = _mapper.Map<Member>(member);
            return View(memberViewModel);
        }

        // POST: /Member/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Member model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var command = _mapper.Map<UpdateMemberCommand>(model);
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // POST: /Member/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteMemberCommand { Id = id };
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }
    }
}
