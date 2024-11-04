using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.Infra.Repository
{
    public class AboutUsRepository: IAboutUsRepository
    {
        private readonly IDbContext IDbContext;
        public AboutUsRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreateAboutUs(AboutUs aboutUs)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@WebsiteInfoId", aboutUs.websiteInfo, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Information", aboutUs.Information, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CenterImage", aboutUs.CenterImage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@SideImage", aboutUs.SideImage, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("CreateAboutUs", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteAboutUs(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeleteAboutUs", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public AboutUs GetAboutUsById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result =IDbContext.Connection.Query("GetAboutUsById", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<AboutUs> GetALLAboutUs()
        {
            IEnumerable< AboutUs> result =IDbContext.Connection.Query<AboutUs>("GetAllAboutUs",  commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", aboutUs.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@WebsiteInfoId", aboutUs.websiteInfo, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Information", aboutUs.Information, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CenterImage", aboutUs.CenterImage, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@SideImage", aboutUs.SideImage, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("UpdateAboutUs", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
