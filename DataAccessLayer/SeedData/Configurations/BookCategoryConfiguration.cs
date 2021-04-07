using DataDomain.DataTables.Books.BookJoins;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasData(new BookCategory { Id=1, BookId = 1, CategoryId = 1 }, 
                            new BookCategory { Id= 2, BookId = 2, CategoryId = 1 }, 
                            new BookCategory { Id= 3, BookId = 3 , CategoryId = 2 },
                            new BookCategory { Id= 4 , BookId = 3, CategoryId = 3});
        }
    }
}
