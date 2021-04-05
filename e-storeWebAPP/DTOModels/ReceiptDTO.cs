using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateReceiptDTO
    {   
        public string ReceiptNumber { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomLastName { get; set; }
        public DateTime DateCaptured { get; set; }
        public string CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public decimal Amount { get; set; }
    }
    public class ReceiptDTO : CreateReceiptDTO
    {
        public int Id { get; set; }
        public InvoiceDTO Invoice { get; set; }
    }
}
