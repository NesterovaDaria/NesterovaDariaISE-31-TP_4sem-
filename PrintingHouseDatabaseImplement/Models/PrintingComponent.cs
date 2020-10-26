using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouseDatabaseImplement.Models
{
    public class PrintingComponent
    {
        public int Id { get; set; }
        public int PrintingProductId { get; set; }
        public int ComponentId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Component Component { get; set; }
        public virtual PrintingProduct PrintingProduct { get; set; }
    }
}
