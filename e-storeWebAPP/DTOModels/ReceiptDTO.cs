using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateReceiptDTO
    {
       
        public string ReceiptNumber { get; set; }
        public int InvoiceId { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal Change { get; set; }
    }
    public class ReceiptDTO : CreateReceiptDTO
    {
        public int Id { get; set; }
    }
}
