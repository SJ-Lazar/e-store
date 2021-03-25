using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateDiscountDTO
    {
        public string Name { get; set; }
        public int Percentage { get; set; }
    }
    public class DiscountDTO : CreateDiscountDTO
    {
        public int Id { get; set; }
    }
}
