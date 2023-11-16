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
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(Context context) : base(context)
        {
        }

        public void DeleteContact(int contactId)
        {
            DeleteObject(contactId);
        }
        
        public int AddContact(Contact contact)
        {
            return AddObject(contact);
        }

        public int UpdateContact(Contact contact)
        {
            return UpdateObject(contact);
        }

        public IQueryable<Contact> GetContactsByCompanyId(int companyId)
        {
            var contacts = _context.Contacts.Where(a => a.CompanyId == companyId);
            return contacts;
        }

        public Contact? GetContactById(int contactId)
        {
            return GetObjectById(contactId);
        }

        public IQueryable<Contact> GetAllContacts()
        {
            return GetAll();
        }
    }
}
