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
    public class ExperienceRepository: IExperienceRepository
    {
        private readonly IDbContext DbContext;
        public ExperienceRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateExperience(Experience experience)
        {

            var p = new DynamicParameters();
            p.Add("@JobTitle", experience.JobTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Employer", experience.Employer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartDate", experience.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", experience.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@City", experience.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@State", experience.State, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ResumeId", experience.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);



            return DbContext.Connection.ExecuteAsync("CreateExperience", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool UpdateExperience(Experience experience)
        {

            var p = new DynamicParameters();
            p.Add("@JobTitle", experience.JobTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Employer", experience.Employer, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@StartDate", experience.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", experience.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@City", experience.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@State", experience.State, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@ResumeId", experience.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);



            return DbContext.Connection.ExecuteAsync("UpdateExperience", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool DeleteExperience(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync("DeleteExperience", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<Experience> GetExperienceByJobTitle(Experience experience)
        {
            var p = new DynamicParameters();
            p.Add("@JobTitle", experience.JobTitle, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Experience> result = DbContext.Connection.Query<Experience>("GetExperieceByJobTitle", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Experience> GetExperienceByStartDate(Experience experience)
        {
            var p = new DynamicParameters();
            p.Add("@StartDate", experience.StartDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<Experience> result = DbContext.Connection.Query<Experience>("GetExperienceInformationByStartDate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Experience> GetExperienceByEndDate(Experience experience)
        {
            var p = new DynamicParameters();
            p.Add("@EndDate", experience.EndDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            IEnumerable<Experience> result = DbContext.Connection.Query<Experience>("GetExperienceInformationByEndDate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Experience> GetExperienceById(Experience experience)
        {
            var p = new DynamicParameters();
            p.Add("@Id", experience.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Experience> result = DbContext.Connection.Query<Experience>("GetExperienceById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Experience> GetAllExperiences()
        {
            IEnumerable<Experience> result = DbContext.Connection.Query<Experience>("GetAllExperience", CommandType.StoredProcedure);
            return result.ToList();
        }
    }
}
