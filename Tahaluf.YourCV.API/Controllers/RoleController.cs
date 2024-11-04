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
    public class RoleController : Controller
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService _roleService)
        {
            this.roleService = _roleService;
        }

        [HttpPost]
        [Route("CreateRole")]
        [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateRole([FromBody] Role role)
        {
            return roleService.CreateRole(role);
        }

        [HttpGet]
        [Route("GetAllRole")]
        [ProducesResponseType(typeof(List<Role>), StatusCodes.Status200OK)]
        public List<Role> GetAllRole()
        {
            return roleService.GetALLRole();
        }

        [HttpGet]
        [Route("GetAllRoleById/{id}")]
        [ProducesResponseType(typeof(List<Role>), StatusCodes.Status200OK)]
        public List<Role> GetAllRoleById(int id)
        {
            return roleService.GetRoleById(id);
        }

        [HttpDelete]
        [Route("DeleteRole/{id}")]
        [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteRole(int id)
        {
            return roleService.DeleteRole(id);
        }

        [HttpPut]
        [Route("UpdateRole")]
        [ProducesResponseType(typeof(Role), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateRole([FromBody] Role role)
        {
            return roleService.UpdateRole(role);
        }
    }
}
