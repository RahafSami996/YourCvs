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
   public class PermissionRoleRepository: IPermissionRoleRepository
    {
        private readonly IDbContext IDbContext;
        public PermissionRoleRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreatePermessionRole(PermissionRole permessionrole)
        {

            var p = new DynamicParameters();
           p.Add("@PermissionId", permessionrole.PermissionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
           p.Add("@RoleId", permessionrole.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return IDbContext.Connection.ExecuteAsync("CreatePermissionRole", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool UpdatePermessionRole(PermissionRole permessionrole)
        {

            var p = new DynamicParameters();
            p.Add("@Id", permessionrole.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@PermissionId", permessionrole.PermissionId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@RoleId", permessionrole.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return IDbContext.Connection.ExecuteAsync("UpdatePermissionRole", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeletePermessionRole(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeletePermissionRole", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public PermissionRole GetPermessionRoleById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = IDbContext.Connection.Query("GetPermissionRoleById", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<PermissionRole> GetALLPermessionRole()
        {
            IEnumerable<PermissionRole> result = IDbContext.Connection.Query<PermissionRole>("GetAllPermissionRole", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
