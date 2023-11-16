using Contacter.Domain.Enums;
using Contacter.Domain.Interfaces.Concrete;
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
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(Context context) : base(context)
        {
        }

        public IQueryable<Address> GetAddressesByCompanyId(int companyId)
        {
            var addresses = _context.Addresses.Where(a => a.CompanyId == companyId);
            return addresses;
        }

        public IQueryable<Address> GetAddressesByAddressType(AddressType addressType)
        {
            var addresses = _context.Addresses.Where(a => a.AddressType == addressType);
            return addresses;
        }
    }
}
