using AutoMapper;
using Contacter.Application.Mapping;
using Contacter.Application.ViewModels.Address;
using Contacter.Application.ViewModels.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Company
{
    public class CompanyDetailsVM : IMapFrom<Contacter.Domain.Models.Concrete.Company>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public ListAddressForListVM Addresses { get; set; }
        public ListContactForListVM Contacts { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contacter.Domain.Models.Concrete.Company, CompanyDetailsVM>()
                .ForMember(d => d.Addresses, opt => opt.Ignore())
                .ForMember(d => d.Contacts, opt => opt.Ignore());
        }
    }
}
