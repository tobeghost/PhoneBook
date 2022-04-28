using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Book.Models.DTOs;
using PhoneBook.Domain.Users;
using PhoneBook.Framework.Controllers;
using PhoneBook.Services.Users;

namespace PhoneBook.Book.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : BaseController
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet("{userId}")]
        public async Task<List<ContactDto>> GetAllByUserId(string userId)
        {
            var data = await _contactService.GetAllContactsByUserId(userId);

            var response = _mapper.Map<List<ContactDto>>(data);

            return response;
        }

        [HttpGet("{id}")]
        public async Task<ContactDto> GetById(string id)
        {
            var data = await _contactService.GetContactById(id);

            var response = _mapper.Map<ContactDto>(data);

            return response;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);

            await _contactService.InsertContact(contact);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);

            await _contactService.UpdateContact(contact);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _contactService.DeleteContactById(id);

            return Ok();
        }

        [HttpGet("{location}")]
        public async Task<List<ContactDto>> GetAllByLocation(string location)
        {
            var data = await _contactService.GetAllByLocationAsync(location);

            var response = _mapper.Map<List<ContactDto>>(data);

            return response;
        }
    }
}
