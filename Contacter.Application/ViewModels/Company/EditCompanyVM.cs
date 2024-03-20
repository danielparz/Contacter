using AutoMapper;
using Contacter.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Company
{
    public class EditCompanyVM : IMapFrom<Contacter.Domain.Models.Concrete.Company>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string NIP { get; set; }
        public string REGON {  get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contacter.Domain.Models.Concrete.Company, EditCompanyVM>();
        }
    }
}
