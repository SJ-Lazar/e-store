using System;
using System.Collections.Generic;
using System.Text;

namespace DataDomain.DataTables.Transactions
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ReceiptNumber { get; set; }
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal Change { get; set; }
    }
}
