﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Books.BookJoins
{
    public class BookCategory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
