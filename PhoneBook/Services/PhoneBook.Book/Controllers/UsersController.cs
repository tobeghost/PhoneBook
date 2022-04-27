using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Book.Models.DTOs;
using PhoneBook.Domain.Users;
using PhoneBook.Framework.Controllers;
using PhoneBook.Services.Users;

namespace PhoneBook.Book.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<UserDto>> GetAll()
        {
            var data = await _userService.GetAllUsers();

            var response = _mapper.Map<List<UserDto>>(data);

            return response;
        }

        [HttpGet("{id}")]
        public async Task<UserDto> GetById(string id)
        {
            var data = await _userService.GetUserById(id);

            var response = _mapper.Map<UserDto>(data);

            return response;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);

            await _userService.InsertUser(user);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _userService.DeleteUserById(id);

            return Ok();
        }
    }
}
