using DataDomain.DataTables.Books.BookJoins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class BookGenreConfiguration : IEntityTypeConfiguration<BookGenre>
    {
        public void Configure(EntityTypeBuilder<BookGenre> builder)
        {
            builder.HasData(new BookGenre { Id= 1, BookId = 1, GenreId = 1  }, new BookGenre { Id=2, BookId = 2, GenreId = 3 }, new BookGenre {Id=3 , BookId = 6, GenreId = 3 });
        }
    }
}
