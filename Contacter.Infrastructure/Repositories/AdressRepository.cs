using Contacter.Domain.Enums;
using Contacter.Domain.Models;
using Contacter.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Repositories
{
    public class AddressRepository
    {
        private readonly Context _context;

        public AddressRepository(Context context)
        {
            _context = context;
        }

        public void DeleteAddress(int addressId)
        {
            var address = _context.Addresses.Find(addressId);
            if (address != null)
            {
                _context.Addresses.Remove(address);
                _context.SaveChanges();
            }
        }

        public int AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address.Id;
        }

        public int UpdateAddress(Address address)
        {
            var tempAddress = _context.Addresses.FirstOrDefault(c => c.Id == address.Id);
            if (tempAddress != null)
            {
                tempAddress = address;
                _context.SaveChanges();
            }
            return address.Id;
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
            var address = _context.Addresses.FirstOrDefault(c => c.Id == addressId);
            return address;
        }
    }
}
