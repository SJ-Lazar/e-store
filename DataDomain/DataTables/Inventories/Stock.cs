using DataDomain.DataTables.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Inventories
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Value { get; set; }
    }
}
