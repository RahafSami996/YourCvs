using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
  public  interface IPermissionRoleRepository
    {
        public bool CreatePermessionRole(PermissionRole permessionrole);
        public bool UpdatePermessionRole(PermissionRole permessionrole);
        public bool DeletePermessionRole(int id);
        public PermissionRole GetPermessionRoleById(int id);
        public List<PermissionRole> GetALLPermessionRole();
    }
}
