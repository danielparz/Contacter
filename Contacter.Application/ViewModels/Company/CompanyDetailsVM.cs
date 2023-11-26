using Contacter.Application.ViewModels.Address;
using Contacter.Application.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Company
{
    public class CompanyDetailsVM
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public ListAddressForListVM Addresses { get; set; }
        public ListContactForListVM Contacts { get; set; }
    }
}
