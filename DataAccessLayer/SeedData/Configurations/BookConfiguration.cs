using DataDomain.DataTables.Base;
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
                           Description = "Fiction Book by Jane Austen",
                           ISBN = "9780061964367",
                           Title = "Pride and Prejudice",
                           ImagePath = "assets/Products/Books/pp.jpg",
                           DiscountId = 1,
                           TaxId = 1



                       },
                       new Book
                       {
                           Id = 2,
                           Name = "A Game Of Thrones",
                           PurchasePrice = 80.90M,
                           SalePrice = 12.30M,
                           Description = "Fiction Book by GEORGE RR MARTIN",
                           ISBN = "9780316160193",
                           Title = "A Game Of Thrones (A song of fire and ice)",
                           ImagePath = "assets/Products/Books/got.jpg",
                           DiscountId = 2,
                           TaxId = 1

                       },
                       new Book
                       {
                           Id = 3,
                           Name = "Boundaries",
                           PurchasePrice = 259.99M,
                           SalePrice = 199.50M,
                           Description = "Fiction Book by Dr. Henry Cloud",
                           ISBN = "9780316015844",
                           Title = "Boundaries when to say Yes and No",
                           ImagePath = "assets/Products/Books/boundaries.jpg",
                           DiscountId = 3,
                           TaxId = 1

                       });
            #endregion
        }
    }
}
