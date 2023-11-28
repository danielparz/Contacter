using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Contact;
using Contacter.Domain.Interfaces;
using Contacter.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public int AddContact(NewContactVM contact)
        {
            var con = new Contact()
            {
                CompanyId = contact.CompanyId,
                ContactDescription = contact.ContactDescription,
                ContactEmail = contact.ContactEmail,
                ContactName = contact.ContactName,
                ContactPhone = contact.ContactPhone                
            };
            _contactRepository.AddObject(con);

            return con.Id;
        }

        public void DeleteContact(int id)
        {
            _contactRepository.DeleteObject(id);
        }

        public ListContactForListVM GetAllActiveContacts()
        {
            var contacts = _contactRepository.GetAllActive();
            var result = new ListContactForListVM();
            result.Contacts = new List<ContactForListVM>();

            foreach (var contact in contacts)
            {
                var con = new ContactForListVM()
                {
                    Id = contact.Id,
                    ContactDescription = contact.ContactDescription,
                    ContactEmail = contact.ContactEmail,
                    ContactName = contact.ContactName,
                    ContactPhone = contact.ContactPhone
                };
                result.Contacts.Add(con);
            }

            result.Count = result.Contacts.Count;
            return result;
        }

        public ListContactForListVM GetContactsByCompanyId(int companyId)
        {
            var contacts = _contactRepository.GetAllActive().Where(x => x.CompanyId == companyId);
            var result = new ListContactForListVM();
            result.Contacts = new List<ContactForListVM>();

            foreach (var contact in contacts)
            {
                var con = new ContactForListVM()
                {
                    Id = contact.Id,
                    ContactDescription = contact.ContactDescription,
                    ContactEmail = contact.ContactEmail,
                    ContactName = contact.ContactName,
                    ContactPhone = contact.ContactPhone
                };
                result.Contacts.Add(con);
            }

            result.Count = result.Contacts.Count;
            return result;
        }

        public int UpdateContact(NewContactVM contact)
        {
            var con = new Contact()
            {
                CompanyId = contact.CompanyId,
                ContactDescription = contact.ContactDescription,
                ContactEmail = contact.ContactEmail,
                ContactName = contact.ContactName,
                ContactPhone = contact.ContactPhone
            };
            _contactRepository.UpdateObject(con);

            return con.Id;
        }
    }
}
