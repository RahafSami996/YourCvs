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
   public class UserRepository: IUserRepository
    {
        private readonly IDbContext dbContext;

        public UserRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("@FirstName", user.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@LastName", user.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserName", user.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", user.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", user.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", user.City, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@PersonalPhoto", user.PersonalPhoto, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleId", user.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return dbContext.Connection.ExecuteAsync("CreateUser", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<User> GetAllUser()
        {
            IEnumerable<User> result = dbContext.Connection.Query<User>("GetAllUser", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateUser(User user)
        {
            var p = new DynamicParameters();
            p.Add("@Id", user.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@FirstName", user.FirstName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@LastName", user.LastName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", user.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserName", user.UserName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", user.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", user.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Country", user.Country, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", user.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PersonalPhoto", user.PersonalPhoto, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleId", user.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return dbContext.Connection.ExecuteAsync("UpdateUser", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteUser(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbContext.Connection.ExecuteAsync("DeleteUser", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<User> GetUserById(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<User> result = dbContext.Connection.Query<User>("GetUserById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

    }
}
