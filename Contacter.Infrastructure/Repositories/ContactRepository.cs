using Contacter.Domain.Enums;
using Contacter.Domain.Interfaces;
using Contacter.Domain.Models;
using Contacter.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public void DeleteContact(int contactId)
        {
            var contact = _context.Contacts.Find(contactId);
            if (contact != null)
            {
                _context.Contacts.Remove(contact);
                _context.SaveChanges();
            }
        }

        public int AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact.Id;
        }

        public int UpdateContact(Contact contact)
        {
            var tempContact = _context.Contacts.FirstOrDefault(c => c.Id == contact.Id);
            if (tempContact != null)
            {
                tempContact = contact;
                _context.SaveChanges();
            }
            return contact.Id;
        }

        public IQueryable<Contact> GetContactsByCompanyId(int companyId)
        {
            var contacts = _context.Contacts.Where(a => a.CompanyId == companyId);
            return contacts;
        }

        public Contact? GetContactById(int contactId)
        {
            var contact = _context.Contacts.FirstOrDefault(c => c.Id == contactId);
            return contact;
        }

        public IQueryable<Contact> GetAllContacts()
        {
            return _context.Contacts;
        }
    }
}
