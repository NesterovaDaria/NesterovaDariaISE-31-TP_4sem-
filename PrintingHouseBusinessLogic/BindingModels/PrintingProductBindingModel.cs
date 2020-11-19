using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseBusinessLogic.BindingModels
{
    public class PrintingProductBindingModel
    {
        public int? Id { get; set; }
        public string PrintingProductName { get; set; }
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> PrintingComponents { get; set; }
    }
}
