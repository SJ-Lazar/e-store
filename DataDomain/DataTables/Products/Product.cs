using DataDomain.DataTables.Base;
using DataDomain.DataTables.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Products
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string ImagePath { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int TaxId { get; set; }
        public Tax Tax { get; set; }
    }
}
