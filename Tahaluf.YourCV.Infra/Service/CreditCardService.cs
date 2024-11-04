using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.Infra.Service
{
    public class CreditCardService : ICreditCardService
    {
        private readonly ICreditCardRepository CreditCardRepository;
        public CreditCardService(ICreditCardRepository creditCardRepository)
        {
            this.CreditCardRepository = creditCardRepository;
        }
        public bool CreateCreditCard(CreditCard creditCard)
        {
            return CreditCardRepository.CreateCreditCard(creditCard);
        }

        public bool DeleteCreditCard(int id)
        {
            return CreditCardRepository.DeleteCreditCard(id);
        }

        public CreditCard GetCreditCardById(int id)
        {
            return CreditCardRepository.GetCreditCardById(id);
        }

        public List<CreditCard> GetALLCreditCard()
        {
            return CreditCardRepository.GetALLCreditCard();
        }

        public bool UpdateCreditCard(CreditCard creditCard)
        {
            return CreditCardRepository.UpdateCreditCard(creditCard);
        }
    }
}
