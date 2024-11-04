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
    public class ExperienceController : Controller
    {
        private readonly IExperienceService experienceService;

        public ExperienceController(IExperienceService _experienceService)
        {
            experienceService = _experienceService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Experience), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateExperience([FromBody] Experience experience)
        {
            return experienceService.CreateExperience(experience);
        }
        [HttpPut]
        [ProducesResponseType(typeof(Experience), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateExperience([FromBody] Experience experience)
        {
            return experienceService.UpdateExperience(experience);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Experience), StatusCodes.Status200OK)]
        public bool DeleteExperience(int id)
        {
            return experienceService.DeleteExperience(id);
        }
        [HttpPost]
        [Route("GetExperieceByJobTitle")]
        [ProducesResponseType(typeof(List<Experience>), StatusCodes.Status200OK)]
        public List<Experience> GetExperienceByJobTitle(Experience experience)
        {
            return experienceService.GetExperienceByJobTitle(experience);
        }
        [HttpPost]
        [Route("GetExperienceInformationByStartDate")]
        [ProducesResponseType(typeof(List<Experience>), StatusCodes.Status200OK)]
        public List<Experience> GetExperienceByStartDate(Experience experience)
        {
            return experienceService.GetExperienceByStartDate(experience);
        }
        [HttpPost]
        [Route("GetExperienceInformationByEndDate")]
        [ProducesResponseType(typeof(List<Experience>), StatusCodes.Status200OK)]
        public List<Experience> GetExperienceByEndDate(Experience experience)
        {
            return experienceService.GetExperienceByEndDate(experience);
        }
        [HttpPost]
        [Route("GetExperienceById")]
        [ProducesResponseType(typeof(List<Experience>), StatusCodes.Status200OK)]
        public List<Experience> GetExperienceById(Experience experience)
        {
            return experienceService.GetExperienceById(experience);
        }

        [HttpGet]
        [Route("GetAllExperience")]
        [ProducesResponseType(typeof(List<Experience>), StatusCodes.Status200OK)]
        public List<Experience> GetAllExperiences()
        {
            return experienceService.GetAllExperiences();
        }

    }
}
