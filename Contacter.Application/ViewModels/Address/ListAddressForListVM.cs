using AutoMapper;
using Contacter.Application.Mapping;
using Contacter.Application.ViewModels.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Address
{
    public class ListAddressForListVM
    {
        public List<AddressForListVM> Addresses { get; set; }
        public int Count { get; set; }        
    }
}
