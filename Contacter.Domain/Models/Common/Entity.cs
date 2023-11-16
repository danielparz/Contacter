using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models.Common
{
    public class Entity : Auditable
    {
        public int Id { get; set; }
    }
}
