using Contacter.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public Context(DbContextOptions options) : base(options)
        {            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Company>()
                .HasMany(a => a.Addresses).WithOne(b => b.Company)
                .HasForeignKey(c => c.CompanyId);
            builder.Entity<Company>()
                .HasMany(a => a.Contacts).WithOne(b => b.Company)
                .HasForeignKey(c => c.CompanyId);            
        }
    }
}
