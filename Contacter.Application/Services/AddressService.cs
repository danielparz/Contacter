using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Address;
using Contacter.Domain.Interfaces.Concrete;
using Contacter.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public int AddAddress(NewAddressVM address)
        {
            var add = new Address()
            {
                CompanyId = address.CompanyId,
                PostCode = address.PostCode,
                City = address.City,
                Street = address.Street,
                Building = address.Building,
                AddressType = address.AddressType
            };

            _addressRepository.AddObject(add);
            return add.Id;
        }

        public void DeleteAddress(int id)
        {
            _addressRepository.DeleteObject(id);
        }

        public ListAddressForListVM GetAddressesByCompanyId(int companyId)
        {
            var addresses = _addressRepository.GetAllActive().Where(x => x.CompanyId == companyId);
            var result = new ListAddressForListVM();
            result.Addresses = new List<AddressForListVM>();

            foreach (var address in addresses)
            {
                var add = new AddressForListVM()
                {
                    Id = address.Id,
                    AddressType = address.AddressType,
                    PostCode = address.PostCode,
                    City = address.City,
                    Street = address.Street,
                    Building = address.Building
                };
                result.Addresses.Add(add);
            }
            result.Count = result.Addresses.Count;

            return result;
        }

        public ListAddressForListVM GetAllActiveAddresses()
        {
            var addresses = _addressRepository.GetAllActive().ProjectTo<AddressForListVM>(_mapper.ConfigurationProvider).ToList();
            var addressesList = new ListAddressForListVM()
            {
                Addresses = addresses,
                Count = addresses.Count
            };

            return addressesList;
        }

        public int UpdateAddress(UpdateAddressVM address)
        {
            var add = new Address()
            {
                Id = address.Id,
                CompanyId = address.CompanyId,
                PostCode = address.PostCode,
                City = address.City,
                Street = address.Street,
                Building = address.Building,
                AddressType = address.AddressType
            };

            _addressRepository.UpdateObject(add);
            return add.Id;
        }
    }
}