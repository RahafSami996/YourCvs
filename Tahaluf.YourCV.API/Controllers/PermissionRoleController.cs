using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionRoleController : Controller
    {
        private readonly IPermissionRoleService permissionRoleService;

        public PermissionRoleController(IPermissionRoleService permissionRoleService)
        {
            this.permissionRoleService = permissionRoleService;
        }


        [HttpPost]
        [Route("CreatePermissionRole")]
        [ProducesResponseType(typeof(PermissionRole), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreatePermissionRole([FromBody] PermissionRole permissionRole)
        {
            return permissionRoleService.CreatePermessionRole(permissionRole);
        }

        [HttpGet]
        [Route("GetAllPermissionRole")]
        [ProducesResponseType(typeof(List<PermissionRole>), StatusCodes.Status200OK)]
        public List<PermissionRole> GetAllPermissionRole()
        {
            return permissionRoleService.GetALLPermessionRole();
        }

        [HttpGet]
        [Route("GetAllPermissionRoleById/{id}")]
        [ProducesResponseType(typeof(PermissionRole), StatusCodes.Status200OK)]
        public PermissionRole GetAllPermissionRoleById(int id)
        {
            return permissionRoleService.GetPermessionRoleById(id);
        }

        [HttpDelete]
        [Route("DeletePermissionRole/{id}")]
        [ProducesResponseType(typeof(PermissionRole), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeletePermissionRole(int id)
        {
            return permissionRoleService.DeletePermessionRole(id);
        }

        [HttpPut]
        [Route("UpdatePermissionRole")]
        [ProducesResponseType(typeof(PermissionRole), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdatePermissionRole([FromBody] PermissionRole permissionRole)
        {
            return permissionRoleService.UpdatePermessionRole(permissionRole);
        }
    }
}
