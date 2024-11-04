using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class TemplateDocumentService : ITemplateDocumentService
    {
        private readonly ITemplateDocumentRepository _templateDocumentService;

        public TemplateDocumentService(ITemplateDocumentRepository templateDocumentRepository)
        {
            _templateDocumentService = templateDocumentRepository;
        }

        public bool CreateTemplateDocument(TemplateDocument templateDocument)
        {
            return _templateDocumentService.CreateTemplateDocument(templateDocument);
        }

        public bool DeleteTemplateDocument(int id)
        {
            return _templateDocumentService.DeleteTemplateDocument(id);
        }

        public IEnumerable<TemplateDocument> GetAllTemplateDocument()
        {
            return _templateDocumentService.GetAllTemplateDocument();
        }

        public TemplateDocument GetTemplateDocumentById(int id)
        {
            return _templateDocumentService.GetTemplateDocumentById(id);
        }

        public TemplateDocument GetTemplateDocumentByName(string name)
        {
            return _templateDocumentService.GetTemplateDocumentByName(name);
        }

        public bool UpdateTemplateDocument(TemplateDocument templateDocument)
        {
            return _templateDocumentService.UpdateTemplateDocument(templateDocument);
        }
    }
}
