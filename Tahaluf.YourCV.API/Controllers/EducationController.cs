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
    public class EducationController : ControllerBase
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        [HttpPost]
        [Route("CreateEducation")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateEducation([FromBody] Education education)
        {
            return _educationService.CreateEducation(education);
        }

        [HttpDelete]
        [Route("DeleteEducation/{id}")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteEducation(int id)
        {
            return _educationService.DeleteEducation(id);
        }

        [HttpDelete]
        [Route("DeleteEducationByResumeId/{resumeId}")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteEducationByResumeId(int resumeId)
        {
            return _educationService.DeleteEducationByResumeId(resumeId);
        }

        [HttpGet]
        [Route("GetAllEducation")]
        [ProducesResponseType(typeof(List<Education>), StatusCodes.Status200OK)]
        public IEnumerable<Education> GetAllEducation()
        {
            return _educationService.GetAllEducation();
        }

        [HttpGet]
        [Route("GetEducation/{id}")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        public Education GetEducation(int id)
        {
            return _educationService.GetEducation(id);
        }

        [HttpGet]
        [Route("GetEducationByResumeId/{resumeId}")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        public IEnumerable<Education> GetEducationByResumeId(int resumeId)
        {
            return _educationService.GetEducationByResumeId(resumeId);
        }

        [HttpPut]
        [Route("UpdateEducation")]
        [ProducesResponseType(typeof(Education), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateEducation([FromBody] Education education)
        {
            return _educationService.UpdateEducation(education);
        }

    }
}
