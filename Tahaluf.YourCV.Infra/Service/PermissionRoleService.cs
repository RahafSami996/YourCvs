using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class PermissionRoleService : IPermissionRoleService
    {
        private readonly IPermissionRoleRepository permissionRoleRepository;

        public PermissionRoleService(IPermissionRoleRepository permissionRoleRepository)
        {
            this.permissionRoleRepository = permissionRoleRepository;
        }
        public bool CreatePermessionRole(PermissionRole permessionrole)
        {
            return permissionRoleRepository.CreatePermessionRole(permessionrole);
        }

        public bool DeletePermessionRole(int id)
        {
            return permissionRoleRepository.DeletePermessionRole(id);
        }

        public List<PermissionRole> GetALLPermessionRole()
        {
            return permissionRoleRepository.GetALLPermessionRole();
        }

        public PermissionRole GetPermessionRoleById(int id)
        {
            return permissionRoleRepository.GetPermessionRoleById(id);
        }

        public bool UpdatePermessionRole(PermissionRole permessionrole)
        {
            return permissionRoleRepository.UpdatePermessionRole(permessionrole);
        }
    }
}
