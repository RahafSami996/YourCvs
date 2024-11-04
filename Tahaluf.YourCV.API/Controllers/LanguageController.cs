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
    public class LanguageController : Controller
    {
        private readonly ILanguageService languageService;
        public LanguageController(ILanguageService languageService)
        {
            this.languageService = languageService;
        }

        [HttpPost]
        [HttpPost]
        [Route("CreateLanguage")]
        [ProducesResponseType(typeof(Language), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateLanguage([FromBody] Language language)
        {
            return languageService.CreateLanguage(language);
        }

        [HttpGet]
        [Route("GetAllLanguage")]
        [ProducesResponseType(typeof(List<Language>), StatusCodes.Status200OK)]
        public List<Language> GetAllLanguage()
        {
            return languageService.GetALLLanguage();
        }

        [HttpGet]
        [Route("GetAllLanguageById/{id}")]
        [ProducesResponseType(typeof(Language), StatusCodes.Status200OK)]
        public Language GetAllLanguageById(int id)
        {
            return languageService.GetLanguageById(id);
        }

        [HttpDelete]
        [Route("DeleteLanguage/{id}")]
        [ProducesResponseType(typeof(Language), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteLanguage(int id)
        {
            return languageService.DeleteLanguage(id);
        }

        [HttpPut]
        [Route("UpdateLanguage")]
        [ProducesResponseType(typeof(Language), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateLanguage([FromBody] Language language)
        {
            return languageService.UpdateLanguage(language);
        }

    }
}
