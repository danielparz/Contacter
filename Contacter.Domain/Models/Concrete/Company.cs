using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacter.Domain.Models.Common;
using Contacter.Domain.Models.Concrete;

namespace Contacter.Domain.Models
{
    public class Company : Entity
    {
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }

        //public virtual User User { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
