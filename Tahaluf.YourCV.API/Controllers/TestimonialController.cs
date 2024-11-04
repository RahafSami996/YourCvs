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
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        [HttpPost]
        [Route("CreateTestimonial")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateTestimonial([FromBody] Testimonial testimonial)
        {
            return _testimonialService.CreateTestimonial(testimonial);
        }

        [HttpDelete]
        [Route("DeleteTestimonial/{id}")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteTestimonial(int id)
        {
            return _testimonialService.DeleteTestimonial(id);
        }

        [HttpGet]
        [Route("GetAllTestimonial")]
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        public IEnumerable<Testimonial> GetAllTestimonial()
        {
            return _testimonialService.GetAllTestimonial();
        }

        [HttpGet]
        [Route("GetTestimonial/{id}")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        public Testimonial GetTestimonial(int id)
        {
            return _testimonialService.GetTestimonial(id);
        }

        [HttpGet]
        [Route("GetTestimonialByWebsiteId/{websiteInfoId}")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        public Testimonial GetTestimonialByWebsiteId(int websiteInfoId)
        {
            return _testimonialService.GetTestimonialByWebsiteId(websiteInfoId);
        }

        [HttpPut]
        [Route("UpdateTestimonial")]
        [ProducesResponseType(typeof(Testimonial), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTestimonial([FromBody] Testimonial testimonial)
        {
            return _testimonialService.UpdateTestimonial(testimonial);
        }

    }
}
