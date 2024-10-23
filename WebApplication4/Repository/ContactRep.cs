using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Repository
{
    public class ContactRep : IContactsRep
    {
        private readonly EFDBContext _context;
        public ContactRep(EFDBContext context)
        {
            _context = context;
        }

        public Contact CreateContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public void DeleteContact(Contact contact)
        {
            var IsExistContact = GetContactById(contact.ContactId);
            if (IsExistContact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }

        }

        public IEnumerable<Contact> GetAllContacts()
        {
            var contact = _context.Contacts.ToList();
            return _context.Contacts.ToList();
        }

        public Contact GetContactById(int id)
        {
            var content= _context.Contacts.Find(id);
            return _context.Contacts.Find(id);
        }

        public void UpdateContact( Contact contact)
        {
            _context.Entry(contact).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
