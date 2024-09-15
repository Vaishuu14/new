using LibraryManagmentSystem.Domain.Entities;
using LibraryManagmentSystem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.Infrastructure.Repositories
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AuthenticateUserAsync(Login model)
        {
            // Ensure to add proper hashing and security measures for passwords
            var user = await _userRepository.GetUserByUserNameAndPasswordAsync(model.UserName, model.Password);

            if (user == null)
            {
                // Handle authentication failure
                throw new UnauthorizedAccessException("Invalid username or password.");
            }

            return user;
        }

        public async Task<User> RegisterUserAsync(Registration model)
        {
            // Check if user already exists
            var existingUser = await _userRepository.GetUserByUserNameAndPasswordAsync(model.UserName, model.Password);
            if (existingUser != null)
            {
                throw new InvalidOperationException("User already exists.");
            }

            // Create and save the new user
            var newUser = new User
            {
                UserName = model.UserName,
                Password = model.Password, // Ensure password is hashed
                Email = model.Email,
                Role = model.Role // Set default role or specify role as needed
            };

            // Assuming you have a method to save the user
            // await _userRepository.AddUserAsync(newUser); 

            return newUser;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            return await _userRepository.GetUserByIdAsync(userId);
        }
    }
}
