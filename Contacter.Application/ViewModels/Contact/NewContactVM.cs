﻿using AutoMapper;
using Contacter.Application.Mapping;
using Contacter.Application.ViewModels.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Application.ViewModels.Contact
{
    public class NewContactVM : IMapFrom<Contacter.Domain.Models.Concrete.Contact>
    {
        public int CompanyId { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactDescription { get; set; }
        public string ContactPhone { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Contacter.Domain.Models.Concrete.Contact, NewContactVM>();
        }
    }
}
