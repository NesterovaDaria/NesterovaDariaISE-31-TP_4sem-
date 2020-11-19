using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PrintingHouseBusinessLogic.Enums;
using PrintingHouseFileImplement.Models;

namespace PrintingHouseFileImplement
{
    public class FileDataListSingleton
    {
        private static FileDataListSingleton instance;
        private readonly string ComponentFileName = "Component.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string PrintingProductFileName = "PrintingProduct.xml";
        private readonly string PrintingProductComponentFileName = "PrintingProductComponent.xml";
        public List<Component> Components { get; set; }
        public List<Order> Orders { get; set; }
        public List<PrintingProduct> PrintingProducts { get; set; }
        public List<PrintingComponent> PrintingProductComponents { get; set; }
        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Orders = LoadOrders();
            PrintingProducts = LoadPrintingProducts();
            PrintingProductComponents = LoadPrintingProductComponents();
        }
        public static FileDataListSingleton GetInstance()
        {
            if (instance == null)
            {
                instance = new FileDataListSingleton();
            }
            return instance;
        }
        ~FileDataListSingleton()
        {
            SaveComponents();
            SaveOrders();
            SavePrintingProducts();
            SavePrintingProductComponents();
        }
        private List<Component> LoadComponents()
        {
            var list = new List<Component>();
            if (File.Exists(ComponentFileName))
            {
                XDocument xDocument = XDocument.Load(ComponentFileName);
                var xElements = xDocument.Root.Elements("Component").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new Component
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ComponentName = elem.Element("ComponentName").Value
                    });
                }
            }
            return list;
        }
        private List<Order> LoadOrders()
        {
            var list = new List<Order>();
                if (File.Exists(OrderFileName))
                {
                    XDocument xDocument = XDocument.Load(OrderFileName);
                    Console.WriteLine("xDocument " + xDocument.ToString());
                    var xElements = xDocument.Root.Elements("Order").ToList();
                    Console.WriteLine("xElements"+xElements.Count);
                    foreach (var ind in xElements)
                    {
                        Console.WriteLine("YES");
                        Console.WriteLine(ind.Value);
                    }
                    foreach (var elem in xElements)
                    {
                        list.Add(new Order
                        {
                            Id = Convert.ToInt32(elem.Attribute("Id").Value),
                            PrintingProductId = Convert.ToInt32(elem.Element("PrintingProductId").Value),
                            Count = Convert.ToInt32(elem.Element("Count").Value),
                            Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                            Status = (OrderStatus)Enum.Parse(typeof(OrderStatus),elem.Element("Status").Value),
                            DateCreate = Convert.ToDateTime(elem.Element("DateCreate").Value),
                            DateImplement =
                       string.IsNullOrEmpty(elem.Element("DateImplement").Value) ? (DateTime?)null :
                       Convert.ToDateTime(elem.Element("DateImplement").Value),
                        });
                    }
                }
                return list;
            }
        private List<PrintingProduct> LoadPrintingProducts()
        {
            var list = new List<PrintingProduct>();
            if (File.Exists(PrintingProductFileName))
            {
                XDocument xDocument = XDocument.Load(PrintingProductFileName);
                var xElements = xDocument.Root.Elements("PrintingProduct").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new PrintingProduct
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        PrintingProductName = elem.Element("PrintingProductName").Value,
                        Price = Convert.ToDecimal(elem.Element("Price").Value)
                    });
                }
            }
            return list;
        }
        private List<PrintingComponent> LoadPrintingProductComponents()
        {
            var list = new List<PrintingComponent>();
            if (File.Exists(PrintingProductComponentFileName))
            {
                XDocument xDocument = XDocument.Load(PrintingProductComponentFileName);
                var xElements = xDocument.Root.Elements("PrintingProductComponent").ToList();
                foreach (var elem in xElements)
                {
                    list.Add(new PrintingComponent
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        PrintingProductId = Convert.ToInt32(elem.Element("PrintingProductId").Value),
                        ComponentId = Convert.ToInt32(elem.Element("ComponentId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value)
                    });
                }
            }
            return list;
        }
        private void SaveComponents()
        {
            if (Components != null)
            {
                var xElement = new XElement("Components");
                foreach (var component in Components)
                {
                    xElement.Add(new XElement("Component",
                    new XAttribute("Id", component.Id),
                    new XElement("ComponentName", component.ComponentName)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ComponentFileName);
            }
        }
        private void SaveOrders()
        {
            if (Orders != null)
            {
                var xElement = new XElement("Orders");
                foreach (var order in Orders)
                {
                    xElement.Add(new XElement("Order",
                    new XAttribute("Id", order.Id),
                    new XElement("PrintingProductId", order.PrintingProductId),
                    new XElement("Count", order.Count),
                    new XElement("Sum", order.Sum),
                    new XElement("Status", order.Status),
                    new XElement("DateCreate", order.DateCreate),
                    new XElement("DateImplement", order.DateImplement)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(OrderFileName);
            }
        }
        private void SavePrintingProducts()
        {
            if (PrintingProducts != null)
            {
                var xElement = new XElement("PrintingProducts");
                foreach (var product in PrintingProducts)
                {
                    xElement.Add(new XElement("PrintingProduct",
                    new XAttribute("Id", product.Id),
                    new XElement("PrintingProductName", product.PrintingProductName),
                    new XElement("Price", product.Price)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(PrintingProductFileName);
            }
        }
        private void SavePrintingProductComponents()
        {
            if (PrintingProductComponents != null)
            {
                var xElement = new XElement("PrintingProductComponents");
                foreach (var productComponent in PrintingProductComponents)
                {
                    xElement.Add(new XElement("PrintingProductComponent",
                    new XAttribute("Id", productComponent.Id),
                    new XElement("PrintingProductId", productComponent.PrintingProductId),
                    new XElement("ComponentId", productComponent.ComponentId),
                    new XElement("Count", productComponent.Count)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(PrintingProductComponentFileName);
            }
        }
    }
}
