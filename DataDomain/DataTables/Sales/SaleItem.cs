using DataDomain.DataTables.Products;
using DataDomain.DataTables.Transactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Sales
{
    public class SaleItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int TaxId { get; set; }
        public Tax Tax { get; set; }
        public decimal Total { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
    }
}