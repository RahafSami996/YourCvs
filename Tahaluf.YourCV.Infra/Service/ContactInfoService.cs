using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
    public class ContactInfoService : IContactInfoService
    {
        private readonly IContactInfoRepository contactInfoRepository;

        public ContactInfoService(IContactInfoRepository _contactInfoRepository)
        {
            contactInfoRepository = _contactInfoRepository;
        }
        public bool CreateContactInfo(ContactInfo contactInfo)
        {
            return contactInfoRepository.CreateContactInfo(contactInfo);
        }

        public bool DeleteContactInfo(int id)
        {
            return contactInfoRepository.DeleteContactInfo(id);
        }

        public List<ContactInfo> GetAllContactInfo()
        {
            return contactInfoRepository.GetAllContactInfo();
        }

        public ContactInfo GetContactInfoById (int id)
        {
            return contactInfoRepository.GetContactInfoById(id);
        }

        public bool UpdateContactInfo(ContactInfo contactInfo)
        {
            return contactInfoRepository.UpdateContactInfo(contactInfo);
        }
    }
}
