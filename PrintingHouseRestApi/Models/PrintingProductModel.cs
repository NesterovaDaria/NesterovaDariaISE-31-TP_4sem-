using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrintingHouseRestApi.Models
{
    public class PrintingProductModel
    {
        public int Id { get; set; }
        public string PrintingProductName { get; set; }
        public decimal Price { get; set; }
    }
}
