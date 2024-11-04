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
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext _dbContext;

        public TestimonialRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("@Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Title", testimonial.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", testimonial.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", testimonial.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("CreateTestimonial", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("DeleteTestimonial", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public IEnumerable<Testimonial> GetAllTestimonial()
        {
            return _dbContext.Connection.Query<Testimonial>("GetAllTestimonial", commandType: CommandType.StoredProcedure);
        }

        public Testimonial GetTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<Testimonial>("GetTestimonial", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public Testimonial GetTestimonialByWebsiteId(int websiteInfoId)
        {
            var p = new DynamicParameters();
            p.Add("@WebsiteInfoId", websiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<Testimonial>("GetTestimonialByWebsiteId", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public bool UpdateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("@Id", testimonial.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Title", testimonial.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", testimonial.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", testimonial.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("UpdateTestimonial", p, commandType: CommandType.StoredProcedure).Result > 0;
        }
    }
}
