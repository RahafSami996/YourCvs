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
   public class ProjectRepository: IProjectRepository
    {
        private readonly IDbContext dbContext;

        public ProjectRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateProject(Project project)
        {
            var p = new DynamicParameters();
            p.Add("@Name", project.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", project.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", project.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("CreateProject", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<Project> GetAllProject()
        {
            IEnumerable<Project> result = dbContext.Connection.Query<Project>("GetAllProject", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateProject(Project project)
        {
            var p = new DynamicParameters();
            p.Add("@Id", project.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", project.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", project.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", project.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("UpdateProject", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public bool DeleteProject(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbContext.Connection.ExecuteAsync("DeleteProject", p, commandType: CommandType.StoredProcedure).Result>0;
        }


        public List<Project> GetProjectById(Project project)
        {
            var p = new DynamicParameters();
            p.Add("@Id", project.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Project> result = dbContext.Connection.Query<Project>("GetProjectById", CommandType.StoredProcedure);
            return result.ToList();

        }
    }
}
