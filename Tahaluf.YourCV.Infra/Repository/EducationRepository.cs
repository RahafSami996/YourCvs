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
    public class EducationRepository : IEducationRepository
    {
        private readonly IDbContext _dbContext;

        public EducationRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateEducation(Education education)
        {
            var p = new DynamicParameters();
            p.Add("@SchoolName", education.SchoolName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", education.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@State", education.State, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Degree", education.Degree, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartDate", education.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@GraduationDate", education.GraduationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@ResumeId", education.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("CreateEducation", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteEducation(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("DeleteEducation", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteEducationByResumeId(int resumeId)
        {
            var p = new DynamicParameters();
            p.Add("@ResumeId", resumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("DeleteEducationByResumeId", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public IEnumerable<Education> GetAllEducation()
        {
            return _dbContext.Connection.Query<Education>("GetAllEducation", commandType: CommandType.StoredProcedure);
        }

        public Education GetEducation(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<Education>("GetEducation", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public IEnumerable<Education> GetEducationByResumeId(int resumeId)
        {
            var p = new DynamicParameters();
            p.Add("@ResumeId", resumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<Education>("GetEducationByResumeId", p, commandType: CommandType.StoredProcedure);
        }

        public bool UpdateEducation(Education education)
        {
            var p = new DynamicParameters();
            p.Add("@Id", education.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@SchoolName", education.SchoolName, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", education.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@State", education.State, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Degree", education.Degree, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartDate", education.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@GraduationDate", education.GraduationDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@ResumeId", education.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("UpdateEducation", p, commandType: CommandType.StoredProcedure).Result > 0;
        }
    }
}
