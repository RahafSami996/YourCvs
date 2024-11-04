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
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService contactUsService;

        public ContactUsController(IContactUsService _contactUsService)
        {
            contactUsService = _contactUsService;
        }

        [HttpPost]
        [Route("CreateContactUs")]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateContactUs([FromBody] ContactUs contactUs)
        {
            return contactUsService.CreateContactUs(contactUs);
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<ContactUs>), StatusCodes.Status200OK)]
        public List<ContactUs> GetAllContactUs()
        {
            return contactUsService.GetAllContactUs();
        }

        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateContactUs([FromBody] ContactUs contactUs)
        {
            return contactUsService.UpdateContactUs(contactUs);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]

        public bool DeleteContactUs(int id)
        {
            return contactUsService.DeleteContactUs(id);
        }


        [HttpPost]
        [Route("GetContactUsById")]
        [ProducesResponseType(typeof(ContactUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public List<ContactUs> GetContactUsById(ContactUs contactUs)
        {
            return contactUsService.GetContactUsById(contactUs);
        }
    }
}
