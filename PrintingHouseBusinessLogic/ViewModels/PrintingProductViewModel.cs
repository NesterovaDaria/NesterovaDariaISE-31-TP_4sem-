using System;
using PrintingHouseBusinessLogic.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Runtime.Serialization;

namespace PrintingHouseBusinessLogic.ViewModels
{
    /// <summary>
    /// Изделие, изготавливаемое в типографии
    /// </summary>
    [DataContract]
    public class PrintingProductViewModel : BaseViewModel
    {
        [Column(title: "Название изделия", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string PrintingProductName { get; set; }
        [Column(title: "Цена", width: 50)]
        [DataMember]
       
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> PrintingComponents { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "PrintingProductName",
            "Price"
        };
    }
}

