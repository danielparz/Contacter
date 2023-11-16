using Contacter.Domain.Models;
using Contacter.Domain.Models.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacter.Infrastructure.Data
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

            builder.Entity<Address>()
                .HasOne(a => a.Company).WithMany(b => b.Addresses)
                .HasForeignKey(c => c.CompanyId);
            builder.Entity<Contact>()
                .HasOne(a => a.Company).WithMany(b => b.Contacts)
                .HasForeignKey(c => c.CompanyId);
        }
    }
}
