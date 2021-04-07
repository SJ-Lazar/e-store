using DataDomain.DataTables.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category{Id = 1, Name = "Fiction" }, new Category { Id = 2, Name = "Non-Fiction" }, new Category {Id = 3, Name = "Educational" });
        }
    }
}
