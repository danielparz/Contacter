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
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context)
        {
        }

        public void DeleteCompany(int companyId)
        {
            DeleteObject(companyId);
        }

        public int AddCompany(Company company)
        {
           return AddObject(company);
        }

        public int UpdateCompany(Company company)
        {
            return UpdateObject(company);   
        }

        public IQueryable<Company> GetAllCompanies()
        {
            return GetAll();
        }

        public Company? GetCompanyById(int companyId)
        {
            return GetObjectById(companyId);
        }
    }
}
