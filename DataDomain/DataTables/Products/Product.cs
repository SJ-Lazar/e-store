﻿using System;
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
    }
}
