using PhoneBook.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services.Users
{
    /// <summary>
    /// Contact service interface
    /// </summary>
    public interface IContactService
    {
        /// <summary>
        /// Create new contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Task InsertContact(Contact contact);

        /// <summary>
        /// Delete contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Task DeleteContact(Contact contact);

        /// <summary>
        /// Delete contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Task DeleteContactById(string contactId);

        /// <summary>
        /// Update contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        Task UpdateContact(Contact contact);

        /// <summary>
        /// Get contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        Task<Contact> GetContactById(string contactId);

        /// <summary>
        /// Get all contact by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<List<Contact>> GetAllContactsByUserId(string userId);

        /// <summary>
        /// Get all contact by location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        Task<List<Contact>> GetAllByLocationAsync(string location);
    }
}
