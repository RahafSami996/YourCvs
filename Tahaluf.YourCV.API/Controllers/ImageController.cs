using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : Controller
    {
        private readonly IImageService imageService;

        public ImageController(IImageService _imageService)
        {
            imageService = _imageService;
        }
        [HttpPost]
        [ProducesResponseType(typeof(Image), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateImage([FromBody] Image image)
        {
            return imageService.CreateImage(image);
        }
        [HttpPut]
        [ProducesResponseType(typeof(Image), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateImage([FromBody] Image image)
        {
            return imageService.UpdateImage(image);
        }
        [HttpDelete]
        [Route("delete/{id}")]
        [ProducesResponseType(typeof(Image), StatusCodes.Status200OK)]
        public bool DeleteImage(int id)
        {
            return imageService.DeleteImage(id);
        }
        [HttpGet]
        [Route("GetAllImage")]
        [ProducesResponseType(typeof(List<Image>), StatusCodes.Status200OK)]

        public List<Image> GetAllImage()
        {
            return imageService.GetAllImage();
        }
    }
}
