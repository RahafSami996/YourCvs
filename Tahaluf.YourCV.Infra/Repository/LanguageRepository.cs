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
    public class LanguageRepository : ILanguageRepository
    {
        private readonly IDbContext IDbContext;
        public LanguageRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreateLanguage(Language language)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@Name", language.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Level", language.Level, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ResumeId", language.ResumeId, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("CreateLanguage", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteLanguage(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeleteLanguage", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public Language GetLanguageById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = IDbContext.Connection.Query("GetLanguageById", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<Language> GetALLLanguage()
        {
            IEnumerable<Language> result = IDbContext.Connection.Query<Language>("GetAllLanguage", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateLanguage(Language language)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", language.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Name", language.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Level", language.Level, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ResumeId", language.ResumeId, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("UpdateLanguage", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
