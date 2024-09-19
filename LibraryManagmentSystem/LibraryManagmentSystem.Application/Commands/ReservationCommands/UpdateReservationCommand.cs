﻿using LibraryManagmentSystem.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Application.Commands.ReservationCommands
{
    public class UpdateReservationCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public DateTime ReservationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
