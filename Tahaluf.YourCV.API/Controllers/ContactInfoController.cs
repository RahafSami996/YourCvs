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
    public class ContactInfoController : Controller
    {
        private readonly IContactInfoService contactInfoService;
        public ContactInfoController(IContactInfoService contactInfoService)
        {
            this.contactInfoService = contactInfoService;
        }

        [HttpPost]
        [Route("CreateContactInfo")]
        [ProducesResponseType(typeof(ContactInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateContactInfo([FromBody] ContactInfo contactInfo)
        {
            return contactInfoService.CreateContactInfo(contactInfo);
        }
        [HttpGet]
        [Route("GetAllContactInfo")]
        [ProducesResponseType(typeof(List<ContactInfo>), StatusCodes.Status200OK)]
        public List<ContactInfo> GetAllContactInfo()
        {
            return contactInfoService.GetAllContactInfo();
        }

        [HttpGet]
        [Route("GetAllContactInfoById/{id}")]
        [ProducesResponseType(typeof(ContactInfo), StatusCodes.Status200OK)]
        public ContactInfo GetAllContactInfoById(int id)
        {
            return contactInfoService.GetContactInfoById(id);
        }

        [HttpDelete]
        [Route("DeleteContactInfo/{id}")]
        [ProducesResponseType(typeof(ContactInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteContactInfo(int id)
        {
            return contactInfoService.DeleteContactInfo(id);
        }

        [HttpPut]
        [Route("UpdateContactInfo")]
        [ProducesResponseType(typeof(ContactInfo), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateContactInfo([FromBody] ContactInfo contactInfo)
        {
            return contactInfoService.UpdateContactInfo(contactInfo);
        }
    }
}
