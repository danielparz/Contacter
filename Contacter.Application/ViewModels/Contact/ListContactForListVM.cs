using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Contact
{
    public class ListContactForListVM
    {
        public List<ContactForListVM> Contacts { get; set; }
        public int Count { get; set; }
    }
}
