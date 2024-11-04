using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
  public  interface IRoleRepository
    {
        public bool CreateRole(Role role);
        public bool DeleteRole(int id);
        public List<Role> GetRoleById(int id);
        public List<Role> GetALLRole();
        public bool UpdateRole(Role role);


    }
}
