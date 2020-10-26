using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrintingHouseBusinessLogic.ViewModels
{
    public class PrintingProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название печатного изделия")]
        public string PrintingProductName { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        public Dictionary<int, (string, int)> PrintingComponents { get; set; }
    }
}

