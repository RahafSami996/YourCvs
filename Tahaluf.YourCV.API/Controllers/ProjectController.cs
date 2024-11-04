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
    public class ProjectController : Controller
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService _projectService)
        {
            projectService = _projectService;
        }

        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(Project), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateProject([FromBody] Project project)
        {
            return projectService.CreateProject(project);
        }

        [HttpGet]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]
        public List<Project> GetAllProject()
        {
            return projectService.GetAllProject();
        }

        [HttpPut]
        [Route("[action]")]
        [ProducesResponseType(typeof(Project), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateProject([FromBody] Project project)
        {
            return projectService.UpdateProject(project);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Project), StatusCodes.Status200OK)]

        public bool DeleteProject(int id)
        {
            return projectService.DeleteProject(id);
        }


        [HttpPost]
        [Route("[action]")]
        [ProducesResponseType(typeof(List<Project>), StatusCodes.Status200OK)]

        public List<Project> GetProjectById(Project project)
        {
            return projectService.GetProjectById(project);
        }
    }
}
