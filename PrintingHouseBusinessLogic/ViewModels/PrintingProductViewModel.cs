using System;
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
    public class PrintingProductViewModel
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [DisplayName("Название изделия")]
        public string PrintingProductName { get; set; }
        [DataMember]
        [DisplayName("Цена")]
        public decimal Price { get; set; }
        [DataMember]
        public Dictionary<int, (string, int)> PrintingComponents { get; set; }
    }
}

