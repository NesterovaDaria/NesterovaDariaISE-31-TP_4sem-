using PrintingHouseListImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseListImplement
{
    public class DataListSingleton
    {
        private static DataListSingleton instance;
        public List<Client> Clients { get; set; }
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<PrintingProduct> PrintingProducts { get; set; }
        public List<PrintingComponent> PrintingComponents { get; set; }
        private DataListSingleton()
        {
            Components = new List<Component>();
            Clients = new List<Client>();
            Orders = new List<Order>();
            PrintingProducts = new List<PrintingProduct>();
            PrintingComponents = new List<PrintingComponent>();
        }

        public static DataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new DataListSingleton();
            }
            return instance;
        }
    }
}
