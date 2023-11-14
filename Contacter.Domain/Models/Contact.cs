using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models
{
    public  class Contact : Auditable
    {
        public int CompanyId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactDescription { get; set; }
        public string ContactPhone { get; set; }

        public virtual Company Company { get; set; }
    }
}
