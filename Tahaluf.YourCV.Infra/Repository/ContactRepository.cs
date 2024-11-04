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
    public class ContactRepository : IContactRepository
    {
        private readonly IDbContext DbContext;
        public ContactRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateContact(Contact contact)
        {
           
                var p = new DynamicParameters();
                p.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@Email", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@Address", contact.Address, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@City", contact.City, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@State", contact.State, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@ZipCode", contact.ZipCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
                p.Add("@LinkedIn", contact.LinkedIn, dbType: DbType.String, direction: ParameterDirection.Input);
                p.Add("@FacebookProfile", contact.FacebookProfile, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", contact.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            return DbContext.Connection.ExecuteAsync("CreateContactUser", p, commandType: CommandType.StoredProcedure).Result>0;
           
        }
        public bool UpdateContact(Contact contact)
        {
            var p = new DynamicParameters();
            p.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", contact.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Address", contact.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@City", contact.City, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@State", contact.State, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ZipCode", contact.ZipCode, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@LinkedIn", contact.LinkedIn, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@FacebookProfile", contact.FacebookProfile, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@ResumeId", contact.ResumeId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            return DbContext.Connection.ExecuteAsync("UpdateContactUser", p, commandType: CommandType.StoredProcedure).Result>0;
        }
        public bool DeleteContact(int id)
        {
            var p = new DynamicParameters();
            p.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            return DbContext.Connection.ExecuteAsync("DeleteContactUser", p, commandType: CommandType.StoredProcedure).Result>0;
        }

        public List<Contact> GetContactByName(Contact contact)
        {
            var p = new DynamicParameters();
            p.Add("@Name", contact.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Contact> result = DbContext.Connection.Query<Contact>("GetByContactName", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<Contact> GetContactById(Contact contact)
        {
            var p = new DynamicParameters();
            p.Add("@Id", contact.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<Contact> result = DbContext.Connection.Query<Contact>("GetContactById", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
        public List<Contact> GetAllContacts()
        {
            IEnumerable<Contact> result = DbContext.Connection.Query<Contact>("GetAllContact", CommandType.StoredProcedure);
            return result.ToList();
        }

    }
}
