using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseDatabaseImplement.Models;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingHouseDatabaseImplement.Implements
{
    public class OrderLogic : IOrderLogic
    {
        //private readonly PrintingHouseDatabase source;
        public void CreateOrUpdate(OrderBindingModel model)
        {
            Console.WriteLine("Ordtr logic fio= " + model.ClientFIO);
            using (var context = new PrintingHouseDatabase())
            {
                Order order;
                if (model.Id.HasValue)
                {
                    order = context.Orders.ToList().FirstOrDefault(rec => rec.Id == model.Id);
                    if (order == null)
                        throw new Exception("Элемент не найден");
                }
                else
                {
                    order = new Order();
                    context.Orders.Add(order);
                }
                order.PrintingProductId = model.PrintingProductId;
                order.ClientFIO = model.ClientFIO;
                order.ClientId = model.ClientId;
                order.Count = model.Count;
                order.DateCreate = model.DateCreate;
                order.DateImplement = model.DateImplement;
                order.Status = model.Status;
                order.Sum = model.Sum;
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                Order order = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (order != null)
                {
                    context.Orders.Remove(order);
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
                context.SaveChanges();
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                return context.Orders.Where(rec => model == null || rec.Id == model.Id || (rec.DateCreate >= model.DateFrom)
                && (rec.DateCreate <= model.DateTo) || model.ClientId == rec.ClientId)
                .Include(ord => ord.PrintingProduct)
                .Select(rec => new OrderViewModel()
                {
                    Id = rec.Id,
                    PrintingProductId = rec.PrintingProductId,
                    ClientFIO = rec.ClientFIO,
                    ClientId = rec.ClientId,
                    PrintingProductName = rec.PrintingProduct.PrintingProductName,
                    Count = rec.Count,
                    DateCreate = rec.DateCreate,
                    DateImplement = rec.DateImplement,
                    Status = rec.Status,
                    Sum = rec.Sum
                }).ToList();
            }
        }
    }
}
