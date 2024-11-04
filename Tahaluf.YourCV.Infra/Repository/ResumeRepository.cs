using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.ViewModel;

namespace Tahalut.YourCV.Infra.Repository
{
    public class ResumeRepository : IResumeRepository
    {
        private readonly IDbContext IDbContext;
        public ResumeRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreateResume(Resume resume)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@PersonName", resume.PersonName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PersonSummary", resume.PersonSummary, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@UserId", resume.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@TemplateDocumentId", resume.TemplateDocumentId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("CreateResume", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteResume(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeleteResume", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        Resume IResumeRepository.GetResumeById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = IDbContext.Connection.Query("GetResumeById", parameters, commandType: CommandType.StoredProcedure);

            return result.SingleOrDefault();
        }

        public List<Resume> GetResumeByUserId(int userId)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", userId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return IDbContext.Connection.Query<Resume>("GetResumeByUserId", p, commandType: CommandType.StoredProcedure).ToList();
        }

        public List<Resume> GetALLResume()
        {
            IEnumerable<Resume> result = IDbContext.Connection.Query<Resume>("GetAllResume", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateResume(Resume resume)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", resume.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PersonName", resume.PersonName, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@PersonSummary", resume.PersonSummary, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@UserId", resume.UserId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@TemplateDocumentId", resume.TemplateDocumentId, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("UpdateResume", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
} 

