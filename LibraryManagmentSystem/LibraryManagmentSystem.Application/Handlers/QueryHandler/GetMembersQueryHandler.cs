﻿using AutoMapper;
using LibraryManagmentSystem.Application.DTOs;
using LibraryManagmentSystem.Application.Queries.MemberQueries;
using LibraryManagmentSystem.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Application.Handlers.QueryHandler
{
    public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, List<MemberDto>>
    {
        private readonly IMemberRepository _memberRepository;
        private readonly IMapper _mapper;

        public GetMembersQueryHandler(IMemberRepository memberRepository, IMapper mapper)
        {
            _memberRepository = memberRepository;
            _mapper = mapper;
        }

        public async Task<List<MemberDto>> Handle(GetMembersQuery request, CancellationToken cancellationToken)
        {
            var members = await _memberRepository.GetAllAsync();
            return _mapper.Map<List<MemberDto>>(members);
        }

    }
}
