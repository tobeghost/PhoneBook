using AutoMapper;
using PhoneBook.Book.Models.DTOs;
using PhoneBook.Domain.Users;

namespace PhoneBook.Book.Mappers
{
    public class ContactMappingProfile : Profile
    {
        public ContactMappingProfile()
        {
            CreateMap<Contact, ContactDto>()
                .ForMember(x => x.ContactType, x => x.MapFrom(c => c.Type));

            CreateMap<ContactDto, Contact>()
                .ForMember(x => x.Type, x => x.MapFrom(c => c.ContactType));

            CreateMap<Contact, CreateContactDto>()
                .ForMember(x => x.ContactType, x => x.MapFrom(c => c.Type));

            CreateMap<CreateContactDto, Contact>()
                .ForMember(x => x.Type, x => x.MapFrom(c => c.ContactType));
        }
    }
}
