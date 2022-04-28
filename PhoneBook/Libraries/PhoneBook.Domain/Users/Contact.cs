using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Users
{
    /// <summary>
    /// Represents a contact
    /// </summary>
    public partial class Contact : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Gets or sets the contact type
        /// </summary>
        public ContactType Type { get; set; }

        /// <summary>
        /// Gets or sets the contact value
        /// </summary>
        public string Value { get; set; }
    }
}
