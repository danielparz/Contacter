﻿using Contacter.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models
{
    public class Address : Auditable
    {
        public int CompanyId { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public AddressTypeEnum AddressType { get; set; }

        public virtual Company Company { get; set; }
    }
}