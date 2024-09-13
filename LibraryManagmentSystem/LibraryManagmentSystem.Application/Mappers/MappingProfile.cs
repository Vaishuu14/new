using AutoMapper;
using LibraryManagmentSystem.Application.Commands.BookCommands;
using LibraryManagmentSystem.Application.Commands.LoanCommands;
using LibraryManagmentSystem.Application.Commands.MemberCommands;
using LibraryManagmentSystem.Application.DTOs;
using LibraryManagmentSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping between Book and BookDto
            CreateMap<Book, BookDto>().ReverseMap();

           

            // Mapping between Member and MemberDto
            CreateMap<Member, MemberDto>().ReverseMap();
           

            // Mapping between Loan and LoanDto
            CreateMap<Loan, LoanDto>().ReverseMap();
           
            

            // Mapping between Fine and FineDto 
            CreateMap<Fine, FineDto>().ReverseMap();

            // Mapping between Reservation and ReservationDto 
            CreateMap<Reservation, ReservationDto>().ReverseMap();

            CreateMap<User , UserDto>().ReverseMap();
        }

    }
}
