using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Users
{
    public enum ContactType
    {
        /// <summary>
        /// Represents user's phone number
        /// </summary>
        PhoneNumber = 1,

        /// <summary>
        /// Represents user's email
        /// </summary>
        Email = 2,

        /// <summary>
        /// Represents user's location
        /// </summary>
        Location = 3
    }
}
