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
    public class TemplateDocumentRepository : ITemplateDocumentRepository
    {
        private readonly IDbContext _dbContext;

        public TemplateDocumentRepository(IDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public bool CreateTemplateDocument(TemplateDocument templateDocument)
        {
            var p = new DynamicParameters();
            p.Add("@Name", templateDocument.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CoverImage", templateDocument.CoverImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Price", templateDocument.Price, dbType: DbType.Double, direction: ParameterDirection.Input);

            return _dbContext.Connection.ExecuteAsync("CreateTemplateDocument", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public bool DeleteTemplateDocument(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("DeleteTemplateDocument", p, commandType: CommandType.StoredProcedure).Result > 0;
        }

        public IEnumerable<TemplateDocument> GetAllTemplateDocument()
        {
            return _dbContext.Connection.Query<TemplateDocument>("GetAllTemplateDocument", commandType: CommandType.StoredProcedure);
        }

        public TemplateDocument GetTemplateDocumentById(int id)
        {
        

            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<TemplateDocument>("GetTemplateDocumentById", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public TemplateDocument GetTemplateDocumentByName(string name)
        {
            var p = new DynamicParameters();
            p.Add("@Name", name, dbType: DbType.String, direction: ParameterDirection.Input);
            return _dbContext.Connection.Query<TemplateDocument>("GetTemplateDocumentByName", p, commandType: CommandType.StoredProcedure).SingleOrDefault();
        }

        public bool UpdateTemplateDocument(TemplateDocument templateDocument)
        {
            var p = new DynamicParameters();
            p.Add("@Id", templateDocument.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", templateDocument.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CoverImage", templateDocument.CoverImage, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Price", templateDocument.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            return _dbContext.Connection.ExecuteAsync("UpdateTemplateDocument", p, commandType: CommandType.StoredProcedure).Result > 0;
        }
    }
}
