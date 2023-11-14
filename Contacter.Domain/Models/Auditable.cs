using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models
{
    public class Auditable
    {
        public int Id { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public User? ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
    }
}
