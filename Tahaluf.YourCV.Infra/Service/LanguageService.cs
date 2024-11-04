using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.Infra.Service
{
   public class LanguageService : ILanguageService
    {
        private readonly ILanguageRepository languageRepository;
        public LanguageService(ILanguageRepository languageRepository)
        {
            this.languageRepository = languageRepository;
        }
        public bool CreateLanguage(Language language)
        {
            return languageRepository.CreateLanguage(language);
        }

        public bool DeleteLanguage(int id)
        {
            return languageRepository.DeleteLanguage(id);
        }

        public Language GetLanguageById(int id)
        {
            return languageRepository.GetLanguageById(id);
        }

        public List<Language> GetALLLanguage()
        {
            return languageRepository.GetALLLanguage();
        }
        
        public bool UpdateLanguage(Language language)
        {
            return languageRepository.UpdateLanguage(language);
        }
    }
}
