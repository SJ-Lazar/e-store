using DataDomain.DataTables.Sales;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Transactions
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal Total { get; set; }

        //Navs
        public  ICollection<SaleItem> SaleItems { get; set; }
    }
}
