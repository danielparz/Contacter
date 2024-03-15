﻿using Contacter.Domain.Interfaces.Common;
using Contacter.Domain.Models.Concrete;
using Contacter.Infrastructure.Data;
using Contacter.Infrastructure.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Repositories.Common
{
    public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(Context context) : base(context)
        {
        }        
    }
}
