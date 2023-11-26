using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Company
{
    public class ListCompaniesForListVM
    {
        public List<CompanyForListVM> Companies { get; set; }
        public int Count { get; set; }
    }
}
