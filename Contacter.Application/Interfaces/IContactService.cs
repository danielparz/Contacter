using Contacter.Application.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Interfaces
{
    public interface IContactService
    {
        int AddContact(NewContactVM contact);
        void DeleteContact(int id);
        int UpdateContact(NewContactVM contact);
        ListContactForListVM GetContactsByCompanyId(int companyId);
    }
}
