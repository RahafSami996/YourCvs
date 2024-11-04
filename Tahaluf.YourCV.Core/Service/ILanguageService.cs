using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface ILanguageService
    {
        public bool CreateLanguage(Language language);
        public List<Language> GetALLLanguage();
        public Language GetLanguageById(int id);
        public bool DeleteLanguage(int id);
        public bool UpdateLanguage(Language language);
    }
}

