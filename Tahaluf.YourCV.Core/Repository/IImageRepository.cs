using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface IImageRepository
    {
        bool CreateImage(Image image);
        bool UpdateImage(Image image);
        bool DeleteImage(int id);
        List<Image> GetAllImage();

    }
}
