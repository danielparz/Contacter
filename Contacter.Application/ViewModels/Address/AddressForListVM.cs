using AutoMapper;
using Contacter.Application.Mapping;
using Contacter.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Address
{
    public class AddressForListVM : IMapFrom<Contacter.Domain.Models.Concrete.Address>
    {
        public int Id { get; set; }
        public AddressType AddressType { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contacter.Domain.Models.Concrete.Address, AddressForListVM>()
                .ForMember(a => a.Id, opt => opt.MapFrom(b => b.Id))
                .ForMember(a => a.AddressType, opt => opt.MapFrom(b => b.AddressType))
                .ForMember(a => a.PostCode, opt => opt.MapFrom(b => b.PostCode))
                .ForMember(a => a.City, opt => opt.MapFrom(b => b.City))
                .ForMember(a => a.Street, opt => opt.MapFrom(b => b.Street))
                .ForMember(a => a.Building, opt => opt.MapFrom(b => b.Building));
        }
    }
}
