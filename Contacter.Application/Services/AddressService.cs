using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Address;
using Contacter.Domain.Interfaces.Common;
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
            var add = new Address();
            add = _mapper.Map<Address>(address);            
            _addressRepository.AddObject(add);

            return add.Id;
        }

        public void DeleteAddress(int id)
        {
            _addressRepository.DeleteObject(id);
        }

        public AddressVM GetAddressById(int id)
        {
            var address = _addressRepository.GetObjectById(id);
            var addressVm = _mapper.Map<AddressVM>(address);

            return addressVm;
        }

        public ListAddressForListVM GetAddressesByCompanyId(int companyId)
        {
            var addresses = _addressRepository.GetAllActive().Where(x => x.CompanyId == companyId).ProjectTo<AddressForListVM>(_mapper.ConfigurationProvider).ToList();
            var result = new ListAddressForListVM()
            {
                Addresses = addresses,
                Count = addresses.Count
            };

            return result;
        }

        public ListAddressForListVM GetAllActiveAddresses()
        {
            var addresses = _addressRepository.GetAllActive().ProjectTo<AddressForListVM>(_mapper.ConfigurationProvider).ToList();
            var result = new ListAddressForListVM()
            {
                Addresses = addresses,
                Count = addresses.Count
            };

            return result;
        }

        public int UpdateAddress(UpdateAddressVM address)
        {
            var add = new Address();
            add = _mapper.Map<Address>(add);
            _addressRepository.UpdateObject(add);

            return add.Id;
        }
    }
}