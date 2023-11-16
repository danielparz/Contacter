using Contacter.Domain.Enums;
using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces.Concrete
{
    public interface IAddressRepository : IBaseRepository<Address>
    {
        IQueryable<Address> GetAddressesByCompanyId(int companyId);
        IQueryable<Address> GetAddressesByAddressType(AddressType addressType);
    }
}
