using DataDomain.DataTables.Books.BookJoins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData(new BookAuthor { Id = 1, BookId = 1, AuthorId = 1 }, 
                            new BookAuthor { Id = 2, BookId = 2, AuthorId = 2 }, 
                            new BookAuthor { Id = 3, BookId = 3, AuthorId = 3 });
        }
    }
}
