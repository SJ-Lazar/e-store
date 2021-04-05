using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Books.BookJoins
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
      
    }
}
