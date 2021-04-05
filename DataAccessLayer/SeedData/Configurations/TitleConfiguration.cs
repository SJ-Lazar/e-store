using DataDomain.DataTables.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
        {
            builder.HasData(new Title { Id = 1, Name ="Mr" }, new Title { Id = 2, Name = "Mrs" }, new Title { Id = 3, Name = "Miss" }, new Title { Id = 4, Name = "Dr" });
        }
    }
}
