using AutoMapper;
using LibraryManagmentSystem.Application.Commands;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Commands.MemberCommands;
using LibraryManagmentSystem.Application.Queries;
using LibraryManagmentSystem.Application.Queries.MemberQueries;
using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Web.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using LibraryManagmentSystem.Application.DTOs;

namespace LibraryManagmentSystem.Web.Controllers
{
    //[Authorize(Roles = "Admin")] // Ensure only Admins can access this controller
    public class MemberController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        private readonly IMemberRepository _memberService;

        public MemberController(IMapper mapper, IMediator mediator, IMemberRepository memberService)
        {
            _mapper = mapper;
            _mediator = mediator;
            _memberService = memberService;
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
            var query = new GetMemberByIdQuery { Id = id };
            var member = await _mediator.Send(query);

            if (member == null)
            {
                return NotFound();
            }

            var memberDto = _mapper.Map<MemberDto>(member); // Map Member to MemberDto
            return View(memberDto);
        }


        // GET: /Member/Create
        public IActionResult Create()
        {
            return View(new CreateMemberCommand());
        }

        // POST: /Member/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateMemberCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }


        // GET: /Member/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var memberDto = await _memberService.GetByIdAsync(id);
            if (memberDto == null)
            {
                return NotFound();
            }

            var updateMemberCommand = _mapper.Map<UpdateMemberCommand>(memberDto);
            return View(updateMemberCommand);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateMemberCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }

            return View(command);
        }



        // POST: /Member/Delete/5
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteMemberCommand { Id = id }; // Ensure correct command for deleting a member
            await _mediator.Send(command);
            return RedirectToAction(nameof(Index));
        }



    }
}
