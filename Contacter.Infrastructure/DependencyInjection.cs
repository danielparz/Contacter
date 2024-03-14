using Contacter.Domain.Interfaces;
using Contacter.Domain.Interfaces.Concrete;
using Contacter.Infrastructure.Repositories.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IAddressRepository, AddressRepository>();
            services.AddTransient<ICompanyRepository, CompanyRepository>();
            services.AddTransient<IContactRepository, ContactRepository>();

            return services;
        }
    }
}
