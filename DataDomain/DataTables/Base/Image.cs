using DataDomain.DataTables.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Base
{
    public class Image
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public ICollection<Product> Products {get; set;}
    }
}
