using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using LibraryManagmentSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryDBContext _context;

        public UserRepository(LibraryDBContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByUserNameAndPasswordAsync(string username, string password)
        {
            return await _context.Users
                .SingleOrDefaultAsync(u => u.UserName == username && u.Password == password);
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _context.Users.FindAsync(userId);
        }

    }
}
