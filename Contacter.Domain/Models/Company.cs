using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models
{
    public class Company : Entity
    {
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }

        //public User User { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
