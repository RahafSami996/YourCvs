using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
    public interface IContactInfoRepository
    {
        bool CreateContactInfo(ContactInfo contactInfo);
        List<ContactInfo> GetAllContactInfo();
        bool UpdateContactInfo(ContactInfo contactInfo);
        bool DeleteContactInfo(int id);
        public ContactInfo GetContactInfoById(int id);
    }
}
