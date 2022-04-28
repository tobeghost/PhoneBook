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
    /// Contact Service
    /// </summary>
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _contactRepository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            _contactRepository = contactRepository;
        }

        /// <summary>
        /// Create new contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task InsertContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException("contact");

            await _contactRepository.InsertAsync(contact);
        }

        /// <summary>
        /// Delete contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException("contact");

            await _contactRepository.DeleteAsync(contact);
        }

        /// <summary>
        /// Delete contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteContactById(string contactId)
        {
            if (contactId == null)
                throw new ArgumentNullException("contactId");

            await _contactRepository.DeleteAsync(contactId);
        }

        /// <summary>
        /// Update contact
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task UpdateContact(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException("contact");

            await _contactRepository.UpdateAsync(contact);
        }

        /// <summary>
        /// Get contact by id
        /// </summary>
        /// <param name="contactId"></param>
        /// <returns></returns>
        public virtual async Task<Contact> GetContactById(string contactId)
        {
            return await _contactRepository.GetByIdAsync(contactId);
        }

        /// <summary>
        /// Get all contact by user id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public virtual async Task<List<Contact>> GetAllContactsByUserId(string userId)
        {
            return await _contactRepository.Collection.Find(i => i.UserId.Equals(userId)).ToListAsync();
        }

        /// <summary>
        /// Get all contact by location
        /// </summary>
        /// <param name="location"></param>
        /// <returns></returns>
        public virtual async Task<List<Contact>> GetAllByLocationAsync(string location)
        {
            return await _contactRepository.Collection.Find(i => i.Type == ContactType.Location && i.Value.Equals(location)).ToListAsync();
        }
    }
}
