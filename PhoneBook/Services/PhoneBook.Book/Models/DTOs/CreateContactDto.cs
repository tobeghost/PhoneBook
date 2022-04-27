using PhoneBook.Domain.Users;

namespace PhoneBook.Book.Models.DTOs
{
    public class CreateContactDto
    {
        public string UserId { get; set; }
        public ContactType ContactType { get; set; }
        public string Value { get; set; }
    }
}
