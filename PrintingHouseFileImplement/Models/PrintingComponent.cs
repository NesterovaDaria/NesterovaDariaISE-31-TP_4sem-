using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouseFileImplement.Models
{
    public class PrintingComponent
    {
        public int Id { get; set; }
        public int PrintingProductId { get; set; }
        public int ComponentId { get; set; }
        public int Count { get; set; }
    }
}
