using Contacter.Domain.Enums;
using Contacter.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models.Concrete
{
    public class Address : Entity
    {
        public int CompanyId { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public AddressType AddressType { get; set; }

        public Company Company { get; set; }
    }
}
