using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        public bool CreateRole(Role role)
        {
           return roleRepository.CreateRole(role);
        }

        public bool DeleteRole(int id)
        {
            return roleRepository.DeleteRole(id);
        }

        public List<Role> GetALLRole()
        {
            return roleRepository.GetALLRole();
        }

        public List<Role> GetRoleById(int id)
        {
            return roleRepository.GetRoleById(id);
        }

        public bool UpdateRole(Role role)
        {
            return roleRepository.UpdateRole(role);
        }
    }
}
