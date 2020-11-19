using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseListImplement.Models
{
    public class PrintingComponent
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int IngredientId { get; set; }
        public int Count { get; set; }
    }
}
