using DataDomain.DataTables.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author { Id = 1, FirstName = "Jane", LastName = "Austin", GenderId = 2, TitleId = 3 }, 
                            new Author { Id = 2, FirstName = "George", LastName = "Martin", GenderId = 1, TitleId = 1 },
                            new Author { Id = 3, FirstName = "Henry", LastName = "Cloud", GenderId = 1, TitleId = 4 });
        }
    }
}
