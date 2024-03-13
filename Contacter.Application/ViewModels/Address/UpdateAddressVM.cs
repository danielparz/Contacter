using Contacter.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Address
{
    public class UpdateAddressVM
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public AddressType AddressType { get; set; }
    }
}
