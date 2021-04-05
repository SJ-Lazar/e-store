using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateSaleItemDTO
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; } 
        public decimal Total { get; set; }
        public int InvoiceId { get; set; }
    }
    public class SaleItemDTO : CreateSaleItemDTO
    {
        public int Id { get; set; }
    }
}
