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
                           Name = "Pride and Prejudice",
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
                           PurchasePrice = 80.99M,
                           SalePrice = 250.50M,
                           Description = "Fiction Book by GEORGE RR MARTIN",
                           ISBN = "9780316160193",
                           Title = "A Game Of Thrones",
                           ImagePath = "assets/Products/Books/got.jpg",
                           DiscountId = 2,
                           TaxId = 1
                       },
                       new Book
                       {
                           Id = 3,
                           Name = "Boundaries",
                           PurchasePrice = 59.99M,
                           SalePrice = 199.50M,
                           Description = "Fiction Book by Dr. Henry Cloud",
                           ISBN = "9780316015844",
                           Title = "Boundaries when to say Yes and No",
                           ImagePath = "assets/Products/Books/boundaries.jpg",
                           DiscountId = 3,
                           TaxId = 1
                       },
                        new Book
                        {
                            Id = 4,
                            Name = "Girl A",
                            PurchasePrice = 80.00M,
                            SalePrice = 120.00M,
                            Description = "A Girl Intrigue In",
                            ISBN = "9780316015844",
                            Title = "Girl A",
                            ImagePath = "assets/Products/Books/GirlA.jfif",
                            DiscountId = 3,
                            TaxId = 1

                        },
                         new Book
                         {
                             Id = 5,
                             Name = "The Handmaid's Tale",
                             PurchasePrice = 120.99M,
                             SalePrice = 209.50M,
                             Description = "Fiction Book by Julia Cameron",
                             ISBN = "9780316015844",
                             Title = "The Handmaid's Tale",
                             ImagePath = "assets/Products/Books/thehandmaidstale.jfif",
                             DiscountId = 2,
                             TaxId = 1

                         },
                          new Book
                          {
                              Id = 6,
                              Name = "The Hobbit",
                              PurchasePrice = 259.99M,
                              SalePrice = 199.50M,
                              Description = "Fiction Book by J.K tolkein",
                              ISBN = "9780316015844",
                              Title = "The Hobbit",
                              ImagePath = "assets/Products/Books/thehobbit.jfif",
                              DiscountId = 3,
                              TaxId = 1

                          });
            #endregion
        }
    }
}
