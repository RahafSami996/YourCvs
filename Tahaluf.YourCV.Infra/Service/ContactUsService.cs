using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsService(IContactUsRepository _contactUsRepository)
        {
            contactUsRepository = _contactUsRepository;
        }

        public bool CreateContactUs(ContactUs contactUs)
        {
            return contactUsRepository.CreateContactUs(contactUs);
        }

        public bool DeleteContactUs(int id)
        {
            return contactUsRepository.DeleteContactUs(id);
        }

        public List<ContactUs> GetAllContactUs()
        {
            return contactUsRepository.GetAllContactUs();
        }

        public List<ContactUs> GetContactUsById(ContactUs contactUs)
        {
            return contactUsRepository.GetContactUsById(contactUs);
        }

        public bool UpdateContactUs(ContactUs contactUs)
        {
            return contactUsRepository.UpdateContactUs(contactUs);
        }
    }
}
