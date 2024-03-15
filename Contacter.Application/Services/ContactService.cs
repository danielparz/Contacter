using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Contact;
using Contacter.Domain.Interfaces.Common;
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
        private readonly IMapper _mapper;

        public ContactService(IContactRepository contactRepository, IMapper mapper)
        {
            _contactRepository = contactRepository;
            _mapper = mapper;
        }   

        public int AddContact(NewContactVM contact)
        {
            var con = new Contact();
            con = _mapper.Map<Contact>(contact);
            _contactRepository.AddObject(con);

            return con.Id;
        }

        public void DeleteContact(int id)
        {
            _contactRepository.DeleteObject(id);
        }

        public ListContactForListVM GetAllActiveContacts()
        {
            var contacts = _contactRepository.GetAllActive().ProjectTo<ContactForListVM>(_mapper.ConfigurationProvider).ToList();
            var result  = new ListContactForListVM()
            {
                Contacts = contacts,
                Count = contacts.Count
            };

            return result;
        }

        public ListContactForListVM GetContactsByCompanyId(int companyId)
        {
            var contacts = _contactRepository.GetAllActive().Where(x => x.CompanyId == companyId).ProjectTo<ContactForListVM>(_mapper.ConfigurationProvider).ToList();
            var result = new ListContactForListVM()
            {
                Contacts = contacts,
                Count = contacts.Count
            };

            return result;
        }

        public int UpdateContact(NewContactVM contact)
        {
            var con = new Contact();
            con = _mapper.Map<Contact>(con);
            _contactRepository.UpdateObject(con);

            return con.Id;
        }
    }
}
