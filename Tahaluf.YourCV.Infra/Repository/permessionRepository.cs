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
   public class PermessionRepository: IPermessionRepository
    {
        private readonly IDbContext DbContext;
        public PermessionRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreatePermession(Permession Permession)
        {

            var p = new DynamicParameters();
            p.Add("@Name", Permession.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync("Createpermission", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool UpdatePermession(Permession Permession)
        {

            var p = new DynamicParameters();
            p.Add("@Id", Permession.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", Permession.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync("Updatepermission", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool DeletePermession(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync("Deletepermession", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public List<Permession> GetPermessionByName(Permession Permession)
        {
            var p = new DynamicParameters();
            p.Add("@Name", Permession.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Permession> result = DbContext.Connection.Query<Permession>("GetPermessionByName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Permession> GetPermessionById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Permession> result = DbContext.Connection.Query<Permession>("GetPermessionById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Permession> GetAllPermession()
        {
            IEnumerable<Permession> result = DbContext.Connection.Query<Permession>("GetAllPermession", CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
