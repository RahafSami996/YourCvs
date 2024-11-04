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
   public class ImageRepository : IImageRepository
    {
        private readonly IDbContext DbContext;
        public ImageRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateImage(Image image)
        {

            var p = new DynamicParameters();
            p.Add("@Name", image.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Path", image.path, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", image.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return DbContext.Connection.ExecuteAsync("CreateImage", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool UpdateImage(Image image)
        {

            var p = new DynamicParameters();
            p.Add("@Name", image.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Path", image.path, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", image.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return DbContext.Connection.ExecuteAsync("UpdateImage", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool DeleteImage(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync(" DeleteImage", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<Image> GetAllImage()
        {
            IEnumerable<Image> result = DbContext.Connection.Query<Image>("GetAllImage", CommandType.StoredProcedure);
            return result.ToList();
        }

    }
}
