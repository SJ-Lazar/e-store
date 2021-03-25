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
    }
    public class BookDTO : CreateBookDTO
    {
        public int Id { get; set; }
    }
    public class UpdateBookDTO : CreateBookDTO
    {

    }
}
