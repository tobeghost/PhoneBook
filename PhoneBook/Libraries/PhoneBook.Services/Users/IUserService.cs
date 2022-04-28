using PhoneBook.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services.Users
{
    /// <summary>
    /// User service interface
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task InsertUser(User user);

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task DeleteUser(User user);

        /// <summary>
        /// Delete user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task DeleteUserById(string userId);

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task UpdateUser(User user);

        /// <summary>
        /// Get user by id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<User> GetUserById(string userId);

        /// <summary>
        /// Gets all users
        /// </summary>
        /// <returns></returns>
        Task<List<User>> GetAllUsers();
    }
}
