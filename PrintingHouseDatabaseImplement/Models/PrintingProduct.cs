using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouseDatabaseImplement.Models
{
    public class PrintingProduct
    {
        public int Id { get; set; }
        [Required]
        public string PrintingProductName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual PrintingComponent PrintingComponent { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
