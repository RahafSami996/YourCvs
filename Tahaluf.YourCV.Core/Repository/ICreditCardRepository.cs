using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface ICreditCardRepository
    {
        public bool CreateCreditCard(CreditCard creditCard);
        public List<CreditCard> GetALLCreditCard();
        public CreditCard GetCreditCardById(int id);
        public bool DeleteCreditCard(int id);
        public bool UpdateCreditCard(CreditCard creditCard);
    }
}
