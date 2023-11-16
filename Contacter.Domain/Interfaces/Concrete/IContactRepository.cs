using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        IQueryable<Contact> GetContactsByCompanyId(int companyId);
    }
}
