using DataDomain.DataTables.Inventories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasData(
                            new Stock
                            {
                                Id = 1,
                                ProductId = 1,
                                Value = 5
                            },
                            new Stock
                            {
                                Id = 2,
                                ProductId = 2,
                                Value = 10
                            },
                            new Stock
                            {
                                Id = 3,
                                ProductId = 3,
                                Value = 50
                            });
        }
    }
}
