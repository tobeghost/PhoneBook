using AutoMapper;
using PhoneBook.Book.Models.DTOs;
using PhoneBook.Domain.Users;

namespace PhoneBook.Book.Mappers
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<User, CreateUserDto>();
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
            CreateMap<CreateUserDto, User>();
        }
    }
}
