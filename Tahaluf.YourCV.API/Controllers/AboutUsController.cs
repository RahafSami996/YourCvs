using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService aboutUsService;
        public AboutUsController(IAboutUsService aboutUsService)
        {
            this.aboutUsService = aboutUsService;
        }

        [HttpPost]
        [Route("CreateAboutUs")]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateAboutUs([FromBody] AboutUs aboutUs)
        {
            return aboutUsService.CreateAboutUs(aboutUs);
        }

        [HttpGet]
        [Route("GetAllAboutUs")]
        [ProducesResponseType(typeof(List<AboutUs>), StatusCodes.Status200OK)]
        public List<AboutUs> GetAllAboutUs()
        {
            return aboutUsService.GetALLAboutUs();
        }

        [HttpGet]
        [Route("GetAllAboutUsById/{id}")]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        public AboutUs GetAllAboutUsById(int id)
        {
            return aboutUsService.GetAboutUsById(id);
        }

        [HttpDelete]
        [Route("DeleteAboutUs/{id}")]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteAboutUs(int id)
        {
            return aboutUsService.DeleteAboutUs(id);
        }

        [HttpPut]
        [Route("UpdateAboutUs")]
        [ProducesResponseType(typeof(AboutUs), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateAboutUs([FromBody] AboutUs aboutUs)
        {
            return aboutUsService.UpdateAboutUs(aboutUs);
        }
    }
}
