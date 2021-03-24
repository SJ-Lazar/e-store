using DataAccessLayer.SeedData.Configurations;
using DataDomain.DataTables.Base;
using DataDomain.DataTables.Books;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public  class eStoreDbContext : IdentityDbContext<User>
    {
        public eStoreDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookConfiguration());
        }
    }
}
