using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly IContactService contactService;

        public ContactController(IContactService _contactService)
        {
            contactService = _contactService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Contact), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateContact([FromBody] Contact contact)
        {
            return contactService.CreateContact(contact);
        }
        [HttpPut]
        [ProducesResponseType(typeof(Contact), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateContact([FromBody] Contact contact)
        {
            return contactService.UpdateContact(contact);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Contact), StatusCodes.Status200OK)]
        public bool DeleteContact(int id)
        {
            return contactService.DeleteContact(id);
        }
        [HttpPost]
        [Route("GetByContactName")]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        public List<Contact> GetContactByName(Contact contact)
        {
            return contactService.GetContactByName(contact);
        }
        [HttpPost]
        [Route("GetContactById")]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        public List<Contact> GetContactById(Contact contact)
        {
            return contactService.GetContactById(contact);
        }
        [HttpGet]
        [Route("GetAllContact")]
        [ProducesResponseType(typeof(List<Contact>), StatusCodes.Status200OK)]
        public List<Contact> GetAllContacts() {
            return contactService.GetAllContacts();
        }
    }
}
