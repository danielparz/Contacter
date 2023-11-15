using Contacter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces
{
    public interface IContactRepository
    {
        void DeleteContact(int contactId);

        int AddContact(Contact contact);

        int UpdateContact(Contact contact);

        IQueryable<Contact> GetContactsByCompanyId(int companyId);

        Contact? GetContactById(int contactId);

        IQueryable<Contact> GetAllContacts();
    }
}
