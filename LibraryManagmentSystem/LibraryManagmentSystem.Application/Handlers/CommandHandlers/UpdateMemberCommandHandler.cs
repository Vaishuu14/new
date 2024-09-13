using AutoMapper;
using LibraryManagmentSystem.Application.Commands.MemberCommands;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Application.Handlers.CommandHandlers
{
    public class UpdateMemberCommandHandler : IRequestHandler<UpdateMemberCommand, Unit>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public UpdateMemberCommandHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateMemberCommand request, CancellationToken cancellationToken)
        {

            var member = await _memberRepository.GetByIdAsync(request.Id);
           // var member = _mapper.Map<Core.Entities.Member>(request);

            _mapper.Map(request, member);
             await _memberRepository.UpdateAsync(member);
            return Unit.Value;
        }

    }
}
