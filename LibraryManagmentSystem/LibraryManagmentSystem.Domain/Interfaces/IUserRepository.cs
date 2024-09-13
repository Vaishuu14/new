using LibraryManagmentSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetUserByUserNameAndPasswordAsync(string userName,string password);
        Task<User> GetUserByIdAsync(int userId);
    }
}
