using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseListImplement.Models
{
    public class PrintingComponent
    {
        public int Id { get; set; }
        public int PrintingProductId { get; set; }
        public int ComponentId { get; set; }
        public int Count { get; set; }
    }
}
