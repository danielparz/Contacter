using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Firstame { get; set; }
        public string? Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        //public ICollection<Company> Companies { get; set; }
    }
}
