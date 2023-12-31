﻿using Contacter.Application.ViewModels.Company;
using Contacter.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.Interfaces
{
    public interface ICompanyService
    {
        int AddCompany(NewCompanyVm company);
        int UpdateCompany(NewCompanyVm company);
        void DeleteCompany(int companyId);
        CompanyDetailsVM GetCompanyDetails(int id);
        ListCompaniesForListVM ListCompaniesForListVM();

    }
}
