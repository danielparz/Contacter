using Contacter.Application.Interfaces;
using Contacter.Application.ViewModels.Address;
using Contacter.Application.ViewModels.Company;
using Contacter.Application.ViewModels.Contact;
using Contacter.Domain.Interfaces.Concrete;
using Contacter.Domain.Models;
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

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public int AddCompany(NewCompanyVm company)
        {
            var result = new Company()
            {
                CompanyName = company.CompanyName,
                NIP = company.NIP,
                REGON = company.REGON,
            };

            _companyRepository.AddObject(result);

            return result.Id;
        }

        public void DeleteCompany(int companyId)
        {
            _companyRepository.DeleteObject(companyId);
        }       

        public CompanyDetailsVM GetCompanyDetails(int id)
        {
            var company = _companyRepository.GetObjectById(id);
            var companyVM = new CompanyDetailsVM();

            companyVM.Id = company.Id;
            companyVM.NIP = company.NIP;
            companyVM.REGON = company.REGON;
            companyVM.CompanyName = company.CompanyName;

            companyVM.Addresses = new ListAddressForListVM();
            companyVM.Contacts = new ListContactForListVM();

            foreach (var address in company.Addresses)
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
                companyVM.Addresses.Addresses.Add(add);
            }
            foreach (var contact in company.Contacts)
            {
                var con = new ContactForListVM()
                {
                    Id = contact.Id,
                    CompanyId = contact.CompanyId,
                    ContactDescription = contact.ContactDescription,
                    ContactEmail = contact.ContactEmail,
                    ContactName = contact.ContactName,
                    ContactPhone = contact.ContactPhone
                };
                companyVM.Contacts.Contacts.Add(con);
            }

            return companyVM;
        }

        public ListCompaniesForListVM ListCompaniesForListVM()
        {
            var companies = _companyRepository.GetAllActive();
            var result = new ListCompaniesForListVM();
            result.Companies = new List<CompanyForListVM>();

            foreach (var company in companies)
            {
                var companyVM = new CompanyForListVM()
                {
                    Id = company.Id,
                    CompanyName = company.CompanyName,
                    NIP = company.NIP
                };
                result.Companies.Add(companyVM);
            }

            result.Count = result.Companies.Count;
            return result;
        }

        public int UpdateCompany(NewCompanyVm company)
        {
            var result = new Company();
            result.CompanyName = company.CompanyName;
            result.NIP = company.NIP;
            result.REGON = company.REGON;

            _companyRepository.UpdateObject(result);

            return result.Id;
        }
    }
}
