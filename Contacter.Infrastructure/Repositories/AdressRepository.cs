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
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        public AddressRepository(Context context) : base(context)
        {
        }

        public void DeleteAddress(int addressId)
        {
            DeleteObject(addressId);
        }

        public int AddAddress(Address address)
        {
            return AddObject(address);
        }

        public int UpdateAddress(Address address)
        {
            return UpdateObject(address);
        }

        public IQueryable<Address> GetAddressesByCompanyId(int companyId)
        {
            var addresses = _context.Addresses.Where(a => a.CompanyId == companyId);
            return addresses;
        }

        public IQueryable<Address> GetAddressesByAddressType(AddressTypeEnum addressType)
        {
            var addresses = _context.Addresses.Where(a => a.AddressType == addressType);
            return addresses;
        }

        public Address? GetAddressById(int addressId)
        {
            return GetObjectById(addressId);
        }
    }
}
