using DataDomain.DataTables.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Sales
{
    public class Discount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Percentage { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
