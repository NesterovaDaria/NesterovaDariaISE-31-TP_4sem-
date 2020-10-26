using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseBusinessLogic.BindingModels
{
    public class CreateOrderBindingModel
    {
        public int PrintingProductId { get; set; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
    }
}
