using Contacter.Application.Interfaces;
using Contacter.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Contacter.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<ICompanyService, CompanyService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
