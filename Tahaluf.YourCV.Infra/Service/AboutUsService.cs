using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;

namespace Tahalut.YourCV.Infra.Service
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IAboutUsRepository aboutUsRepository;
        public AboutUsService(IAboutUsRepository aboutUsRepository)
        {
            this.aboutUsRepository=aboutUsRepository;
        }
        public bool CreateAboutUs(AboutUs aboutUs)
        {
            return aboutUsRepository.CreateAboutUs(aboutUs);
        }

        public bool DeleteAboutUs(int id)
        {
            return aboutUsRepository.DeleteAboutUs(id);
        }

        public AboutUs GetAboutUsById(int id)
        {
            return aboutUsRepository.GetAboutUsById(id);
        }

        public List<AboutUs> GetALLAboutUs()
        {
            return aboutUsRepository.GetALLAboutUs();
        }

        public bool UpdateAboutUs(AboutUs aboutUs)
        {
            return aboutUsRepository.UpdateAboutUs(aboutUs);
        }
    }
}
