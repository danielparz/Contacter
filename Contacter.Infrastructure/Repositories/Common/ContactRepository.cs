using Contacter.Domain.Enums;
using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Concrete;
using Contacter.Infrastructure.Data;
using Contacter.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Repositories.Common
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(Context context) : base(context)
        {
        }

        public IQueryable<Contact> GetContactsByCompanyId(int companyId)
        {
            var contacts = _context.Contacts.Where(a => a.CompanyId == companyId);
            return contacts;
        }
    }
}
