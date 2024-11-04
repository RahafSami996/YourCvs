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
    public class SkillController : Controller
    {
        private readonly ISkillService skillService;

        public SkillController(ISkillService _skillService)
        {
            skillService = _skillService;
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(Skill), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateSkill([FromBody] Skill skill)
        {
            return skillService.CreateSkill(skill);
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<Skill>), StatusCodes.Status200OK)]
        public List<Skill> GetAllskill()
        {
            return skillService.GetAllSkill();
        }

        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(Skill), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateSkill([FromBody] Skill skill)
        {
            return skillService.UpdateSkill(skill);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Skill), StatusCodes.Status200OK)]

        public bool Deleteskill(int id)
        {
            return skillService.DeleteSkill(id);
        }


        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<Skill>), StatusCodes.Status200OK)]

        public List<Skill> GetskillById(Skill skill)
        {
            return skillService.GetSkilltById(skill);
        }
    }
}
