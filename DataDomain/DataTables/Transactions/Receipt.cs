using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Transactions
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ReceiptNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomLastName { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public decimal Amount { get; set; }
    }
}
