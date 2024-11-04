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
    public class PermessionController : Controller
    {
        private readonly IPermessionService PermessionService;

        public PermessionController(IPermessionService _PermessionService)
        {
            PermessionService = _PermessionService;
        }
        [HttpPost]
        [Route("CreatePermession")]
        [ProducesResponseType(typeof(Permession), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreatePermession([FromBody] Permession Permession)
        {
            return PermessionService.CreatePermession(Permession);
        }
        [HttpPut]
        [Route("UpdatePermission")]
        [ProducesResponseType(typeof(Permession), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdatePermession([FromBody] Permession Permession)
        {
            return PermessionService.UpdatePermession(Permession);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Permession), StatusCodes.Status200OK)]

        public bool DeletePermession(int id)
        {
            return PermessionService.DeletePermession(id);
        }
        [HttpPost]
        [Route("GetPermessionByName")]
        [ProducesResponseType(typeof(List<Permession>), StatusCodes.Status200OK)]
        public List<Permession> GetPermessionByName(Permession Permession)
        {
            return PermessionService.GetPermessionByName(Permession);
        }
        [HttpGet]
        [Route("GetPermessionById/{id}")]
        [ProducesResponseType(typeof(List<Permession>), StatusCodes.Status200OK)]
        public List<Permession> GetPermessionById(int id)
        {
            return PermessionService.GetPermessionById(id);
        }
        [HttpGet]
        [Route("GetAllPermession")]
        [ProducesResponseType(typeof(List<Permession>), StatusCodes.Status200OK)]
        public List<Permession> GetAllPermession()
        {
            return PermessionService.GetAllPermession();
        }
    }
}
