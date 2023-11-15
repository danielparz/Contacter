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
    public class CompanyRepository : ICompanyRepository
    {
        private readonly Context _context;

        public CompanyRepository(Context context)
        {
            _context = context;
        }

        public void DeleteCompany(int companyId)
        {
            var company = _context.Companies.Find(companyId);
            if(company != null)
            {
                _context.Companies.Remove(company);
                _context.SaveChanges();
            }
        }

        public int AddCompany(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
            return company.Id;
        }

        public int UpdateCompany(Company company)
        {
            var tempCompany = _context.Companies.FirstOrDefault(c => c.Id == company.Id);
            if(tempCompany != null)
            {
                tempCompany = company;
                _context.SaveChanges();
            }
            return company.Id;
        }

        public IQueryable<Company> GetAll()
        {
            return _context.Companies;
        }

        public Company? GetCompanyById(int companyId)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Id == companyId);
            return company;
        }
    }
}
