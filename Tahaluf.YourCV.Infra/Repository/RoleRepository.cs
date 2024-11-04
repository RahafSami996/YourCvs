using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahaluf.YourCV.Infra.Repository
{
   public class RoleRepository: IRoleRepository
    {
        private readonly IDbContext IDbContext;

        public RoleRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreateRole(Role role)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@Name", role.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("CreateRole", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteRole(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeleteRole", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public List<Role> GetRoleById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Role> result = IDbContext.Connection.Query<Role>("GetRoleById", parameters, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public List<Role> GetALLRole()
        {
            IEnumerable<Role> result = IDbContext.Connection.Query<Role>("GetAllRole", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateRole(Role role)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", role.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@Name", role.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("UpdateRole", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
