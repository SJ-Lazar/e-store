using DataDomain.DataTables.Sales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.SeedData.Configurations
{
    public class DiscountConfiguration : IEntityTypeConfiguration<Discount>
    {
        public void Configure(EntityTypeBuilder<Discount> builder)
        {
            builder.HasData(
                            new Discount
                            {
                                Id = 1,
                                Name = "Hot Deals",
                                Percentage = 25,
                            },
                            new Discount
                            {
                                Id = 2,
                                Name = "Mad Sale",
                                Percentage = 50,
                            },
                            new Discount
                            {
                                Id = 3,
                                Name = "Bargin For More",
                                Percentage = 10,
                            });
        }
    }
}
