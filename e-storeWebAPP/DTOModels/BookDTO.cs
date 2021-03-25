using DataDomain.DataTables.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateBookDTO 
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        [Required]
        [StringLength(maximumLength: 13, ErrorMessage = "ISBN Cannot Exceed 13 Characters")]
        public string ISBN { get; set; }
        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Book Title Is Too Long")]
        public string Title { get; set; }
        public string ImagePath { get; set; }
        public int DiscountId { get; set; }
        public int TaxId { get; set; }
    }
    public class BookDTO : CreateBookDTO
    {
        public int Id { get; set; }

        public DiscountDTO Discount {get; set;}
        public TaxDTO Tax { get; set; }

    }
    public class UpdateBookDTO : BookDTO
    {

    }
}
