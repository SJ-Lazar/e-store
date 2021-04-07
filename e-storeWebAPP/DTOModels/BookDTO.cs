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
        [Required(ErrorMessage = "Name Is Required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description Is Required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Purchase Price Is Required")]
        public decimal PurchasePrice { get; set; }

        [Required(ErrorMessage = "Sale Price Is Required")]
        public decimal SalePrice { get; set; }

        [Required (ErrorMessage = "ISBN Is Required")]
        [StringLength(maximumLength: 13, ErrorMessage = "ISBN Cannot Exceed 13 Characters")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "Name Is Required")]
        [StringLength(maximumLength: 250, ErrorMessage = "Book Title Is Too Long")]
        public string Title { get; set; }

        public string ImagePath { get; set; }
       
        public int DiscountId { get; set; }

        [Required(ErrorMessage = "Tax Is Required")]
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
