using PrintingHouseBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace PrintingHouseBusinessLogic.BindingModels
{
    /// <summary>     
    /// Заказ     
    /// </summary> 
    [DataContract]
    public class OrderBindingModel
    {
        public int? Id { get; set; }
        public int PrintingProductId { get; set; }
        public int ClientId { set; get; }
        public string ClientFIO { set; get; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
