using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : Controller
    {
        private readonly ICreditCardService creditCardService;
        public CreditCardController(ICreditCardService creditCardService)
        {
            this.creditCardService = creditCardService;
        }

        [HttpPost]
        [Route("CreateCreditCard")]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCreditCard([FromBody] CreditCard creditCard)
        {
            return creditCardService.CreateCreditCard(creditCard);
        }

        [HttpGet]
        [Route("GetAllCreditCard")]
        [ProducesResponseType(typeof(List<CreditCard>), StatusCodes.Status200OK)]
        public List<CreditCard> GetAllCreditCard()
        {
            return creditCardService.GetALLCreditCard();
        }

        [HttpGet]
        [Route("GetAllCreditCardById/{id}")]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        public CreditCard GetAllCreditCardById(int id)
        {
            return creditCardService.GetCreditCardById(id);
        }

        [HttpDelete]
        [Route("DeleteCreditCard/{id}")]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCreditCard(int id)
        {
            return creditCardService.DeleteCreditCard(id);
        }

        [HttpPut]
        [Route("UpdateCreditCard")]
        [ProducesResponseType(typeof(CreditCard), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateCreditCard([FromBody] CreditCard creditCard)
        {
            return creditCardService.UpdateCreditCard(creditCard);
        }

    }
}
