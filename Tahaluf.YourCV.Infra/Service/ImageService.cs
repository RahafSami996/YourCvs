using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class ImageService: IImageService
    {
        private readonly IImageRepository imageRepository;

        public ImageService(IImageRepository _imageRepository)
        {
            imageRepository = _imageRepository;
        }
        public bool CreateImage(Image image)
        {
            return imageRepository.CreateImage(image);
        }
        public bool UpdateImage(Image image)
        {
            return imageRepository.UpdateImage(image);
        }
        public bool DeleteImage(int id)
        {
            return imageRepository.DeleteImage(id);
        }
        public List<Image> GetAllImage()
        {
            return imageRepository.GetAllImage();
        }

    }

}
