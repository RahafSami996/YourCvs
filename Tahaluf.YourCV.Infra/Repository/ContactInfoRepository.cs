using System;
using System.Collections.Generic;
using Tahaluf.YourCV.Core.Common;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using System.Text;
using Dapper;
using System.Data;
using System.Linq;

namespace Tahaluf.YourCV.Infra.Repository
{
    public class ContactInfoRepository : IContactInfoRepository
    {
        private readonly IDbContext dbContext;

        public ContactInfoRepository(IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public bool CreateContactInfo(ContactInfo contactInfo)
        {
            var p = new DynamicParameters();
            p.Add("@Titles", contactInfo.Titles, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", contactInfo.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contactInfo.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", contactInfo.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId ", contactInfo.WebsiteInfoId, dbType: DbType.String, direction: ParameterDirection.Input);

            return dbContext.Connection.ExecuteAsync("CreateContactInfo", p, commandType: CommandType.StoredProcedure).Result > 0;

        }

        public bool DeleteContactInfo(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return dbContext.Connection.ExecuteAsync("DeleteContactInfo", p, commandType: CommandType.StoredProcedure).Result > 0;

        }

        public List<ContactInfo> GetAllContactInfo()
        {
            IEnumerable<ContactInfo> result = dbContext.Connection.Query<ContactInfo>("GetAllContactInfo", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public ContactInfo GetContactInfoById(int id)
        {

            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<ContactInfo> result = dbContext.Connection.Query<ContactInfo>("GetContactInfoById", CommandType.StoredProcedure);
            return result.FirstOrDefault();

        }

        public bool UpdateContactInfo(ContactInfo contactInfo)
        {
            var p = new DynamicParameters();
            p.Add("@Id", contactInfo.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Titles", contactInfo.Titles, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", contactInfo.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contactInfo.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", contactInfo.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@WebsiteInfoId ", contactInfo.WebsiteInfoId, dbType: DbType.String, direction: ParameterDirection.Input);

            return dbContext.Connection.ExecuteAsync("UpdateContactInfo", p, commandType: CommandType.StoredProcedure).Result > 0;

        }
    }
}
