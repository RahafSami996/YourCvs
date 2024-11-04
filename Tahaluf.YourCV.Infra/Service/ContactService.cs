using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.YourCV.Core.Data;
using Tahaluf.YourCV.Core.Repository;
using Tahaluf.YourCV.Core.Service;

namespace Tahaluf.YourCV.Infra.Service
{
  public  class ContactService: IContactService
    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository _contactRepository)
        {
            contactRepository = _contactRepository;
        }
        public bool CreateContact(Contact contact)
        {
            return contactRepository.CreateContact(contact);
        }
        public  bool UpdateContact(Contact contact)
        {
            return contactRepository.UpdateContact(contact);
        }
        public bool DeleteContact(int id)
        {
            return contactRepository.DeleteContact(id);
        }
        public List<Contact> GetContactByName(Contact contact)
        {
            return contactRepository.GetContactByName(contact);
        }
        public List<Contact> GetContactById(Contact contact)
        {
            return contactRepository.GetContactById(contact);
        }
        public List<Contact> GetAllContacts()
        {
            return contactRepository.GetAllContacts();
        }



    }
}
