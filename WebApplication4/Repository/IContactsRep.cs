using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Repository
{
    public interface IContactsRep
    {
        Contact CreateContact(Contact contact);
        void UpdateContact(Contact contact);
        void DeleteContact(Contact contact);
        IEnumerable<Contact> GetAllContacts();
        Contact GetContactById(int id);
    }
}
