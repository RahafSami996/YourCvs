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
    public class WebsiteInfoRepository : IWebsiteInfoRepository
    {
        private readonly IDbContext _dbContext;

        public WebsiteInfoRepository(IDbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public bool CreateWebsiteInfo(WebsiteInfo websiteInfo)
        {
            var p = new DynamicParameters();
            p.Add("@Name", websiteInfo.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Title", websiteInfo.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HeadLine", websiteInfo.HeadLine, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", websiteInfo.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Background", websiteInfo.Background, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleId", websiteInfo.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return _dbContext.Connection.ExecuteAsync("CreateWebsiteInfo", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteWebsiteInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("DeleteWebsiteInfo", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public IEnumerable<WebsiteInfo> GetAllWebsiteInfo()
        {
            return _dbContext.Connection.Query<WebsiteInfo>("GetAllWebsiteInfo", commandType: CommandType.StoredProcedure);
        }

        public List<WebsiteInfo> GetWebsiteInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<WebsiteInfo>("GetWebsiteInfo", p, commandType: CommandType.StoredProcedure).ToList();
        }

        public WebsiteInfo GetWebsiteInfoByRoleId(int roleId)
        {
            var p = new DynamicParameters();
            p.Add("@RoleId", roleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<WebsiteInfo>("GetWebsiteInfoByRoleId", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }


        public bool UpdateWebsiteInfo(WebsiteInfo websiteInfo)
        {
            var p = new DynamicParameters();
            p.Add("@Id", websiteInfo.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", websiteInfo.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Title", websiteInfo.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@HeadLine", websiteInfo.HeadLine, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", websiteInfo.Logo, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Background", websiteInfo.Background, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@RoleId", websiteInfo.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return _dbContext.Connection.ExecuteAsync("UpdateWebsiteInfo", p, commandType: CommandType.StoredProcedure).Result > 0;
        }
    }
}
