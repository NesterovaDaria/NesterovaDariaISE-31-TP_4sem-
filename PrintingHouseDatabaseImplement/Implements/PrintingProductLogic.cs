using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PrintingHouseDatabaseImplement.Implements
{
    public class PrintingProductLogic : IPrintingProductLogic
    {
        public void CreateOrUpdate(PrintingProductBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        PrintingProduct element = context.PrintingProducts.FirstOrDefault(rec => rec.PrintingProductName == model.PrintingProductName && rec.Id != model.Id);
                        if (element != null)
                        {
                            throw new Exception("Уже есть корабль с таким названием");
                        }
                        if (model.Id.HasValue)
                        {
                            element = context.PrintingProducts.FirstOrDefault(rec => rec.Id == model.Id);

                            if (element == null)
                            {
                                throw new Exception("Элемент не найден");
                            }
                        }
                        else
                        {
                            element = new PrintingProduct();
                            context.PrintingProducts.Add(element);
                        }

                        element.PrintingProductName = model.PrintingProductName;
                        element.Price = model.Price;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var printingComponents = context.PrintingComponents.Where(rec => rec.PrintingProductId == model.Id.Value).ToList();
                            context.PrintingComponents.RemoveRange(printingComponents.Where(rec => !model.PrintingComponents.ContainsKey(rec.ComponentId)).ToList());
                            context.SaveChanges();
                            foreach (var updateComponent in printingComponents)
                            {
                                updateComponent.Count =
                                model.PrintingComponents[updateComponent.ComponentId].Item2;
                                model.PrintingComponents.Remove(updateComponent.ComponentId);
                            }
                            context.SaveChanges();
                        }
                        foreach (var pc in model.PrintingComponents)
                        {
                            context.PrintingComponents.Add(new PrintingComponent
                            {
                                PrintingProductId = element.Id,
                                ComponentId = pc.Key,
                                Count = pc.Value.Item2
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(PrintingProductBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.PrintingComponents.RemoveRange(context.PrintingComponents.Where(rec => rec.PrintingProductId == model.Id));
                        PrintingProduct element = context.PrintingProducts.FirstOrDefault(rec => rec.Id == model.Id);
                        if (element != null)
                        {
                            context.PrintingProducts.Remove(element);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<PrintingProductViewModel> Read(PrintingProductBindingModel model)
        {
            using (var context = new PrintingHouseDatabase())
            {
                return context.PrintingProducts
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
                .Select(rec => new PrintingProductViewModel
                {
                    Id = rec.Id,
                    PrintingProductName = rec.PrintingProductName,
                    Price = rec.Price,
                    PrintingComponents = context.PrintingComponents
                .Include(recPC => recPC.Component)
                .Where(recPC => recPC.PrintingProductId == rec.Id)
                .ToDictionary(recPC => recPC.ComponentId, recPC =>
                //(recPC.Component?.ComponentName, recPC.Count))
                (recPC.Component.ComponentName, recPC.Count))
                })
                .ToList();
            }
        }

    }
}
