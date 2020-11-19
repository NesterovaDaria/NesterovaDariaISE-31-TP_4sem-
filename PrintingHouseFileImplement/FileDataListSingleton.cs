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
        private readonly string ClientFileName = "Client.xml";
        private readonly string OrderFileName = "Order.xml";
        private readonly string PrintingProductFileName = "PrintingProduct.xml";
        private readonly string PrintingComponentFileName = "PrintingComponent.xml";
        private readonly string ImplementerFileName = "Implementer.xml";
        private readonly string MessageInfoFileName = "MessageInfo.xml";
        public List<Component> Components { get; set; }
        public List<Client> Clients { get; set; }
        public List<Order> Orders { get; set; }
        public List<PrintingProduct> PrintingProducts { get; set; }
        public List<PrintingComponent> PrintingComponents { get; set; }
        public List<Implementer> Implementers { get; set; }
        public List<MessageInfo> MessageInfoes { get; set; }
        private FileDataListSingleton()
        {
            Components = LoadComponents();
            Clients = LoadClients();
            Orders = LoadOrders();
            PrintingProducts = LoadPrintingProducts();
            PrintingComponents = LoadPrintingComponents();
            Implementers = LoadImplementers();
            MessageInfoes = LoadMessageInfoes();
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
            SaveClients();
            SaveOrders();
            SavePrintingProducts();
            SavePrintingComponents();
            SaveImplementers();
            SaveMessageInfoes();
        }
        private List<MessageInfo> LoadMessageInfoes()
        {
            var list = new List<MessageInfo>();

            if (File.Exists(MessageInfoFileName))
            {
                XDocument xDocument = XDocument.Load(MessageInfoFileName);
                var xElements = xDocument.Root.Elements("MessageInfo").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new MessageInfo
                    {
                        MessageId = elem.Attribute("MessageId").Value,
                        ClientId = Convert.ToInt32(elem.Element("ClientId").Value),
                        SenderName = elem.Element("SenderName").Value,
                        DateDelivery = Convert.ToDateTime(elem.Element("DateDelivery").Value),
                        Subject = elem.Element("Subject").Value,
                        Body = elem.Element("Body").Value
                    });
                }
            }
            return list;
        }
            private List<Implementer> LoadImplementers()
        {
            var list = new List<Implementer>();

            if (File.Exists(ImplementerFileName))
            {
                XDocument xDocument = XDocument.Load(ImplementerFileName);
                var xElements = xDocument.Root.Elements("Implementer").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Implementer
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        ImplementerFIO = elem.Element("ImplementerFIO").Value,
                        WorkingTime = Convert.ToInt32(elem.Element("WorkingTime").Value),
                        PauseTime = Convert.ToInt32(elem.Element("PauseTime").Value)
                    });
                }
            }

            return list;
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
        private List<Client> LoadClients()
        {
            var list = new List<Client>();
            if (File.Exists(ClientFileName))
            {
                XDocument xDocument = XDocument.Load(ClientFileName);
                var xElements = xDocument.Root.Elements("Client").ToList();

                foreach (var elem in xElements)
                {
                    list.Add(new Client
                    {
                        Id = Convert.ToInt32(elem.Attribute("Id").Value),
                        FIO = elem.Element("FIO").Value,
                        Login = elem.Element("Email").Value,
                        Password = elem.Element("Password").Value
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
                Console.WriteLine("xElements" + xElements.Count);
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
                        ClientId = Convert.ToInt32(elem.Attribute("ClientId").Value),
                        PrintingProductId = Convert.ToInt32(elem.Element("PrintingProductId").Value),
                        Count = Convert.ToInt32(elem.Element("Count").Value),
                        Sum = Convert.ToDecimal(elem.Element("Sum").Value),
                        Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), elem.Element("Status").Value),
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
        private List<PrintingComponent> LoadPrintingComponents()
        {
            var list = new List<PrintingComponent>();
            if (File.Exists(PrintingComponentFileName))
            {
                XDocument xDocument = XDocument.Load(PrintingComponentFileName);
                var xElements = xDocument.Root.Elements("PrintingComponent").ToList();
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
        private void SaveClients()
        {
            if (Clients != null)
            {
                var xElement = new XElement("Clients");
                foreach (var client in Clients)
                {
                    xElement.Add(new XElement("Client",
                    new XAttribute("Id", client.Id),
                    new XElement("FIO", client.FIO),
                    new XElement("Email", client.Login),
                    new XElement("Password", client.Password)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ClientFileName);
            }
        }
        private void SaveImplementers()
        {
            if (Implementers != null)
            {
                var xElement = new XElement("Implementers");
                foreach (var implementer in Implementers)
                {
                    xElement.Add(new XElement("Implementer",
                    new XAttribute("Id", implementer.Id),
                    new XElement("ImplementerFIO", implementer.ImplementerFIO),
                    new XElement("WorkingTime ", implementer.WorkingTime),
                    new XElement("PauseTime", implementer.PauseTime)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(ImplementerFileName);
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
                    new XAttribute("ClientId", order.ClientId),
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
        private void SavePrintingComponents()
        {
            if (PrintingComponents != null)
            {
                var xElement = new XElement("PrintingComponents");
                foreach (var productComponent in PrintingComponents)
                {
                    xElement.Add(new XElement("PrintingComponent",
                    new XAttribute("Id", productComponent.Id),
                    new XElement("PrintingProductId", productComponent.PrintingProductId),
                    new XElement("ComponentId", productComponent.ComponentId),
                    new XElement("Count", productComponent.Count)));
                }
                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(PrintingComponentFileName);
            }
        }
        private void SaveMessageInfoes()
        {
            if (MessageInfoes!= null)
            {
                var xElement = new XElement("MessageInfoes");

                foreach (var messageInfoes in MessageInfoes)
                {
                    xElement.Add(new XElement("MessageInfo",
                     new XAttribute("Id", messageInfo.MessageId),
                     new XElement("ClientId", messageInfo.ClientId),
                     new XElement("SenderName", messageInfo.SenderName),
                     new XElement("DateDelivery", messageInfo.DateDelivery),
                     new XElement("Subject", messageInfo.Subject),
                     new XElement("Body", messageInfo.Body)));
                }

                XDocument xDocument = new XDocument(xElement);
                xDocument.Save(MessageInfoFileName);
            }
        }
    }
}
