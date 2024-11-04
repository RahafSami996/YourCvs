using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface IAboutUsService
    {
        public bool CreateAboutUs(AboutUs aboutUs);
        public List<AboutUs> GetALLAboutUs();
        public AboutUs GetAboutUsById(int id);
        public bool DeleteAboutUs(int id);
        public bool UpdateAboutUs(AboutUs aboutUs);
    }
}
