using Contacter.Domain.Enums;
using Contacter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces
{
    public interface IAddressRepository
    {
        void DeleteAddress(int addressId);

        int AddAddress(Address address);

        int UpdateAddress(Address address);

        IQueryable<Address> GetAddressesByCompanyId(int companyId);

        IQueryable<Address> GetAddressesByAddressType(AddressTypeEnum addressType);

        Address? GetAddressById(int addressId);
    }
}
