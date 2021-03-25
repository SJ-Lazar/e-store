using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_storeWebAPP.DTOModels
{
    public class CreateStockDTO
    {
        public int ProductId { get; set; }
        public int Value { get; set; }
    } 
    
    public class StockDTO : CreateStockDTO
    {
        public int Id { get; set; }
    }
}
