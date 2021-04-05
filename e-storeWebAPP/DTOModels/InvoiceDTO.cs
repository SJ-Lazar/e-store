using DataDomain.DataTables.Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateInvoiceDTO
    {    
        public string InvoiceNumber { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal Total { get; set; }
        public ICollection<CreateSaleItemDTO> SaleItems { get; set; }
     
    }
    public class InvoiceDTO : CreateInvoiceDTO
    {
        public int Id { get; set; }
    }
}
