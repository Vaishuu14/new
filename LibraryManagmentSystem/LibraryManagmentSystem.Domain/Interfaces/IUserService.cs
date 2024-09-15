using LibraryManagmentSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Domain.Interfaces
{
    public interface IUserService
    {
        Task<User> AuthenticateUserAsync(Login model);
        Task<User> RegisterUserAsync(Registration model);
        Task<User> GetUserByIdAsync(int userId);
    }
}
