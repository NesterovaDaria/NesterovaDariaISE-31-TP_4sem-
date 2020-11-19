using PrintingHouseBusinessLogic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseListImplement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int? ImplementerId { get; set; }
        public int PrintingProductId { get; set; }
        public string ClientFIO { set; get; }
        public int Count { get; set; }
        public decimal Sum { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime? DateImplement { get; set; }

    }
}
