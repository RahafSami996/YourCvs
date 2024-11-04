using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateDocumentController : ControllerBase
    {
        private readonly ITemplateDocumentService _templateDocumentService;

        public TemplateDocumentController(ITemplateDocumentService templateDocumentService)
        {
            _templateDocumentService = templateDocumentService;
        }

        [HttpPost]
        [Route("CreateTemplateDocument")]
        [ProducesResponseType(typeof(TemplateDocument), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateTemplateDocument([FromBody] TemplateDocument templateDocument)
        {
            return _templateDocumentService.CreateTemplateDocument(templateDocument);
        }

        [HttpDelete]
        [Route("DeleteTemplateDocument/{id}")]
        [ProducesResponseType(typeof(TemplateDocument), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteTemplateDocument(int id)
        {
            return _templateDocumentService.DeleteTemplateDocument(id);
        }

        [HttpGet]
        [Route("GetAllTemplateDocument")]
        [ProducesResponseType(typeof(List<TemplateDocument>), StatusCodes.Status200OK)]
        public IEnumerable<TemplateDocument> GetAllTemplateDocument()
        {
            return _templateDocumentService.GetAllTemplateDocument();
        }

        [HttpGet]
        [Route("GetTemplateDocumentById/{id}")]
        [ProducesResponseType(typeof(TemplateDocument), StatusCodes.Status200OK)]
        public TemplateDocument GetTemplateDocumentById(int id)
        {
            return _templateDocumentService.GetTemplateDocumentById(id);
        }

        [HttpGet]
        [Route("GetTemplateDocumentByName/{name}")]
        [ProducesResponseType(typeof(TemplateDocument), StatusCodes.Status200OK)]
        public TemplateDocument GetTemplateDocumentByName(string name)
        {
            return _templateDocumentService.GetTemplateDocumentByName(name);
        }

        [HttpPut]
        [Route("UpdateTemplateDocument")]
        [ProducesResponseType(typeof(TemplateDocument), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTemplateDocument([FromBody] TemplateDocument templateDocument)
        {
            return _templateDocumentService.UpdateTemplateDocument(templateDocument);
        }

        [HttpPost]
        [Route("upload")]
        public TemplateDocument Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                }
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);




                string attachmentFileName = $"{Guid.NewGuid().ToString("N")}_{fileName}.{Path.GetExtension(file.FileName).Replace(".", "")}";
                var fullPath = Path.Combine("C:\\Users\\DELL\\Desktop\\YourCv\\Tahaluf.YourCV.API\\Properties\\assets\\" + "images\\templates\\", attachmentFileName);
                //var fullPath2 = Path.Combine ("C: \\Users\\DELL\\Documents\\YourCV\\src\\assets\\" + "templates\\", attachmentFileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

               

                return new TemplateDocument { CoverImage = attachmentFileName };
            }
            catch (Exception e)
            {
                return null;
            }





        }

    }
}
