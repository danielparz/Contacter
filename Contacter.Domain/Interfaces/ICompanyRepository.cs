using Contacter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        void DeleteCompany(int companyId);

        int AddCompany(Company company);

        int UpdateCompany(Company company);

        IQueryable<Company> GetAll();

        Company? GetCompanyById(int companyId);
    }
}
