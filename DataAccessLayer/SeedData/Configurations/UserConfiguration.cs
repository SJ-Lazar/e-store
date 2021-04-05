using DataDomain.DataTables.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User { Id = "8a2956f3-aaea-4b1c-ad71-989d7287eef8", NormalizedUserName = "ADMIN", FirstName = "salman", LastName = "lazar", UserName = "admin", PasswordHash = "1234", EmailConfirmed = true });
        }
    }
}
