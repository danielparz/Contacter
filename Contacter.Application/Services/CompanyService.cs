using AutoMapper;
using AutoMapper.QueryableExtensions;
using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Address;
using Contacter.Application.ViewModels.Company;
using Contacter.Application.ViewModels.Contact;
using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IAddressService _addressService;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper, IAddressService addressService, IContactService contactService)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
            _addressService = addressService;
            _contactService = contactService;
        }

        public int AddCompany(NewCompanyVM company)
        {
            var com = _mapper.Map<Company>(company);
            _companyRepository.AddObject(com);

            return com.Id;
        }

        public void DeleteCompany(int companyId)
        {
            _companyRepository.DeleteObject(companyId);
        }       

        public CompanyDetailsVM GetCompanyDetails(int id)
        {
            var company = _companyRepository.GetObjectById(id);
            var result = new CompanyDetailsVM();
            result = _mapper.Map<CompanyDetailsVM>(company);
            result.Addresses = _addressService.GetAddressesByCompanyId(id);
            result.Contacts = _contactService.GetContactsByCompanyId(id);            

            return result;
        }

        public ListCompaniesForListVM GetAllCompaniesForList()
        {
            var companies = _companyRepository.GetAllActive().ProjectTo<CompanyForListVM>(_mapper.ConfigurationProvider).ToList();
            var result = new ListCompaniesForListVM()
            {
                Companies = companies,
                Count = companies.Count
            };
            
            return result;
        }

        public int UpdateCompany(EditCompanyVM company)
        {
            var com = _mapper.Map<Company>(company);

            _companyRepository.UpdateObject(com);

            return com.Id;
        }

        public EditCompanyVM GetCompanyForEdit(int id)
        {
            var company = _companyRepository.GetObjectById(id);
            var result = new EditCompanyVM();
            result = _mapper.Map<EditCompanyVM>(company);

            return result;
        }
    }
}
