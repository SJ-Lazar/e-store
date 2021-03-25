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
                           Name = "Book Pride and Prejudice",
                           PurchasePrice = 59.99M,
                           SalePrice = 99.50M,
                           Description = "Fiction Book by Jane",
                           ISBN = "9780061964367",
                           Title = "Pride and Prejudice",
                       },
                       new Book
                       {
                           Id = 2,
                           Name = "Book New Moon(Twilight)",
                           PurchasePrice = 80.90M,
                           SalePrice = 12.30M,
                           Description = "Fiction Book by Jane",
                           ISBN = "9780316160193",
                           Title = "New Moon(Twilight)",
                       },
                       new Book
                       {
                           Id = 3,
                           Name = "A song of ice and fire",
                           PurchasePrice = 259.99M,
                           SalePrice = 199.50M,
                           Description = "Fiction Book by RR Martin",
                           ISBN = "9780316015844",
                           Title = "A song of ice and fire",
                       });
            #endregion
        }
    }
}
