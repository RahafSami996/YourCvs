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
   public  class CreditCardRepository : ICreditCardRepository
    {
        private readonly IDbContext IDbContext;
        public CreditCardRepository(IDbContext IDbContext)
        {
            this.IDbContext = IDbContext;
        }

        public bool CreateCreditCard(CreditCard creditCard)
        {

            var parameters = new DynamicParameters();
            parameters.Add("@Number", creditCard.Number, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CCV", creditCard.CCV, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ExpiryDate", creditCard.ExpiryDate, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@UserId", creditCard.UserId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Balance", creditCard.Balance, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("CreateCreditCard", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteCreditCard(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("DeleteCreditCard", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }

        public CreditCard GetCreditCardById(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = IDbContext.Connection.Query("GetCreditCardById", parameters, commandType: CommandType.StoredProcedure);

            return result.FirstOrDefault();
        }

        public List<CreditCard> GetALLCreditCard()
        {
            
                IEnumerable<CreditCard> result = IDbContext.Connection.Query<CreditCard>("GetAllCreditCard", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateCreditCard(CreditCard creditCard)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Id", creditCard.Id, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Number", creditCard.Number, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@CCV", creditCard.CCV, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@ExpiryDate", creditCard.ExpiryDate, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@UserId", creditCard.UserId, dbType: DbType.String, direction: ParameterDirection.Input);
            parameters.Add("@Balance", creditCard.Balance, dbType: DbType.String, direction: ParameterDirection.Input);
            IDbContext.Connection.ExecuteAsync("UpdateCreditCard", parameters, commandType: CommandType.StoredProcedure);

            return true;
        }


        
        
        
    }
}
