using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Service
{
    public interface IImageService
    {
        bool CreateImage(Image image);
        bool UpdateImage(Image image);
        bool DeleteImage(int id);
        List<Image> GetAllImage();
    }
}
