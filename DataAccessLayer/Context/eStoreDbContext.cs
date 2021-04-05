using DataAccessLayer.SeedData.Configurations;
using DataDomain.DataTables.Base;
using DataDomain.DataTables.Books;
using DataDomain.DataTables.Books.BookJoins;
using DataDomain.DataTables.Inventories;
using DataDomain.DataTables.Products;
using DataDomain.DataTables.Sales;
using DataDomain.DataTables.Transactions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Context
{
    public  class eStoreDbContext : IdentityDbContext<User>
    {
        #region Constructor
        public eStoreDbContext(DbContextOptions options) : base(options) { } 
        #endregion

        #region DbSets
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        #endregion

        #region Override Methods
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new StockConfiguration());
            builder.ApplyConfiguration(new DiscountConfiguration());
            builder.ApplyConfiguration(new TaxConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new GenderConfiguration());
            builder.ApplyConfiguration(new TitleConfiguration());
        } 
        #endregion
    }
}
