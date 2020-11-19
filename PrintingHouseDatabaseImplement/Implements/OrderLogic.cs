using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseDatabaseImplement.Models;
using PrintingHouseBusinessLogic.Enums;
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
        private readonly PrintingHouseDatabase source;
        public void CreateOrUpdate(OrderBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                Order element;
                if (model.Id.HasValue)
                {
                    element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);

                    if (element == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    element = new Order();
                    context.Orders.Add(element);
                }

                element.PrintingProductId = model.PrintingProductId == 0 ? element.PrintingProductId : model.PrintingProductId;
                element.ClientId = model.ClientId.Value;
                element.ImplementerId = model.ImplementerId;
                element.Count = model.Count;
                element.Sum = model.Sum;
                element.Status = model.Status;
                element.DateCreate = model.DateCreate;
                element.DateImplement = model.DateImplement;
                context.SaveChanges();
            }
        }

        public void Delete(OrderBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                Order element = context.Orders.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Orders.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<OrderViewModel> Read(OrderBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                return context.Orders
               .Where(
                   rec => model == null
                   || rec.Id == model.Id && model.Id.HasValue
                   || model.DateFrom.HasValue && model.DateTo.HasValue && rec.DateCreate >= model.DateFrom && rec.DateCreate <= model.DateTo
                   || model.ClientId.HasValue && rec.ClientId == model.ClientId
                   || model.FreeOrders.HasValue && model.FreeOrders.Value && !rec.ImplementerId.HasValue
                   || model.ImplementerId.HasValue && rec.ImplementerId == model.ImplementerId && rec.Status == OrderStatus.Выполняется
               )
               .Include(rec => rec.PrintingProduct)
               .Include(rec => rec.Client)
               .Include(rec => rec.Implementer)
               .Select(rec => new OrderViewModel
               {
                   Id = rec.Id,
                   ClientId = rec.ClientId,
                   ImplementerId = rec.ImplementerId,
                   PrintingProductId = rec.PrintingProductId,
                   Count = rec.Count,
                   Sum = rec.Sum,
                   Status = rec.Status,
                   DateCreate = rec.DateCreate,
                   DateImplement = rec.DateImplement,
                   PrintingProductName = rec.PrintingProduct.PrintingProductName,
                   ClientFIO = rec.Client.FIO,
                   ImplementerFIO = rec.ImplementerId.HasValue ? rec.Implementer.ImplementerFIO : string.Empty,
               })
               .ToList();
            }
        }
    }
}
