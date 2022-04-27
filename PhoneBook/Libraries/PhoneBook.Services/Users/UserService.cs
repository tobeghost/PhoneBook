using MongoDB.Driver;
using PhoneBook.Domain.Data;
using PhoneBook.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services.Users
{
    /// <summary>
    /// User Service
    /// </summary>
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task InsertUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            await _userRepository.InsertAsync(user);
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            await _userRepository.DeleteAsync(user);
        }

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteUserById(string userId)
        {
            if (userId == null)
                throw new ArgumentNullException("userId");

            await _userRepository.DeleteAsync(userId);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task UpdateUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            await _userRepository.UpdateAsync(user);
        }

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>User</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<User> GetUserById(string userId)
        {
            if (string.IsNullOrEmpty(userId))
                throw new ArgumentNullException("userId");

            return await _userRepository.GetByIdAsync(userId);
        }

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.Collection.Find(i => true).SortBy(x => x.Name).ThenBy(x => x.Surname).ToListAsync();
        }
    }
}
