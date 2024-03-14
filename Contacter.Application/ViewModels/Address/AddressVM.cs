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
    public class AddressVM : IMapFrom<Contacter.Domain.Models.Concrete.Address>
    {
        public int Id { get; set; }
        public AddressType AddressType { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contacter.Domain.Models.Concrete.Address, AddressVM>()
                .ForMember(d => d.Id, opt => opt.MapFrom(b => b.Id))
                .ForMember(d => d.AddressType, opt => opt.MapFrom(b => b.AddressType))
                .ForMember(d => d.PostCode, opt => opt.MapFrom(b => b.PostCode))
                .ForMember(d => d.City, opt => opt.MapFrom(b => b.City))
                .ForMember(d => d.Street, opt => opt.MapFrom(b => b.Street))
                .ForMember(d => d.Building, opt => opt.MapFrom(b => b.Building));
        }
    }
}
