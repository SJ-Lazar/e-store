using DataDomain.DataTables.Books;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            #region BookSeedData
            builder.HasData(
                       new Book
                       {
                           Id = 1,
                           ISBN = "9780061964367",
                           Title = "Pride and Prejudice",
                       },
                       new Book
                       {
                           Id = 2,
                           ISBN = "9780316160193",
                           Title = "New Moon(Twilight)",
                       },
                       new Book
                       {
                           Id = 3,
                           ISBN = "9780316015844",
                           Title = "Twilight",
                       });
            #endregion
        }
    }
}
