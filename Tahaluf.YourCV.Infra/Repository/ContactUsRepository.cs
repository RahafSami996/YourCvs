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
   public class ContactUsRepository: IContactUsRepository
    {
        private readonly IDbContext dbContext;

        public ContactUsRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateContactUs(ContactUs contactUs)
        {
            var p = new DynamicParameters();
            p.Add("@Name", contactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", contactUs.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Subject", contactUs.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Message", contactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", contactUs.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("CreateContactUs", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<ContactUs> GetAllContactUs()
        {
            IEnumerable<ContactUs> result = dbContext.Connection.Query<ContactUs>("GetAllContactUs", CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateContactUs(ContactUs contactUs)
        {
            var p = new DynamicParameters();
            p.Add("@Id", contactUs.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Name", contactUs.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contactUs.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", contactUs.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Subject", contactUs.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Message", contactUs.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId", contactUs.WebsiteInfoId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return dbContext.Connection.ExecuteAsync("UpdateContactUs", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public bool DeleteContactUs(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbContext.Connection.ExecuteAsync("DeleteContactUs", p, commandType: CommandType.StoredProcedure).Result>0;
        }


        public List<ContactUs> GetContactUsById(ContactUs contactUs)
        {
            var p = new DynamicParameters();
            p.Add("@Id", contactUs.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<ContactUs> result = dbContext.Connection.Query<ContactUs>("GetContactUsById", CommandType.StoredProcedure);
            return result.ToList();

        }
    }
}
