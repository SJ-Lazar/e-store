using DataDomain.DataTables.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Books
{
    public class Book : Product
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
    }
}
