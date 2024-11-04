using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;

namespace Tahaluf.YourCV.Core.Service
{
   public interface IContactService
    {
        bool CreateContact(Contact contact);
        bool UpdateContact(Contact contact);
        bool DeleteContact(int id);
        List<Contact> GetContactByName(Contact contact);
        List<Contact> GetContactById(Contact contact);
        List<Contact> GetAllContacts();
    }
}
