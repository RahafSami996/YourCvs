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
    public class JwtRepository : IJwtRepository
    {
        private readonly IDbContext IDbContext;
        public JwtRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }
        public User Auth(User user)
        {
            var p = new DynamicParameters();
            p.Add("@UserName", user.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
           
            IEnumerable<User> result = IDbContext.Connection.Query<User>("LOGIN", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
