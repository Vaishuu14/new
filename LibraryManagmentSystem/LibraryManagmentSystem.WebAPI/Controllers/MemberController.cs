using AutoMapper;
using LibraryManagmentSystem.Application.Commands.MemberCommands;
using LibraryManagmentSystem.Application.Queries.MemberQueries;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagmentSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        private readonly IMemberRepository _memberService;

        public MemberController(IMediator mediator, IMapper mapper, IMemberRepository memberService)
        {
            _mediator = mediator;
            _mapper = mapper;
            _memberService = memberService;
        }

        [HttpGet]
        [Route("/member/list")]
        public async Task<IActionResult> MemberList()
        {
            var members = await _mediator.Send(new GetMembersQuery());
            return Ok(members);
        }

        [HttpGet]
        [Route("/member/details")]
        public async Task<IActionResult> MemberDetails(int id)
        {
            var query = new GetMemberByIdQuery { Id = id };
            var result = await _mediator.Send(query);
            if (result == null)
            {
                return NotFound(); // Return NotFoundResult if the member does not exist
            }
            return Ok(result);
        }

        [HttpPost]
        [Route("/member/create")]
        public async Task<IActionResult> CreateMember([FromForm] CreateMemberCommand command)
        {
            if (!ModelState.IsValid)
            {
                // Return the view with validation errors if model state is invalid
                return Ok(command);
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }

        // POST: /Member/Edit
        [HttpPut]
        [Route("/member/update")]
        public async Task<IActionResult> EditMember(UpdateMemberCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return Ok(command);
        }

        [HttpDelete]
        [Route("/member/delete")]
        public async Task<IActionResult> DeleteMember(int id)
        {
            var command = new DeleteMemberCommand { Id = id };
            await _mediator.Send(command);
            return Ok(command);
        }   
    }
}
