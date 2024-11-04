using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Repository
{
   public interface IContactUsRepository
    {
        bool CreateContactUs(ContactUs contactUs);
        List<ContactUs> GetAllContactUs();
        bool UpdateContactUs(ContactUs contactUs);
        bool DeleteContactUs(int id);
        List<ContactUs> GetContactUsById(ContactUs contactUs);
    }
}
