using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface ITemplateDocumentRepository
    {
        bool CreateTemplateDocument(TemplateDocument templateDocument);
        TemplateDocument GetTemplateDocumentById(int id);
        TemplateDocument GetTemplateDocumentByName(string name);
        IEnumerable<TemplateDocument> GetAllTemplateDocument();
        bool UpdateTemplateDocument(TemplateDocument templateDocument);
        bool DeleteTemplateDocument(int id);
    }
}
