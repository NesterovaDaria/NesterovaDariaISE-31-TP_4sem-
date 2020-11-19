using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseFileImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingHouseFileImplement.Implements
{
    public class PrintingProductLogic : IPrintingProductLogic
    {
        private readonly FileDataListSingleton source;
        public PrintingProductLogic()
        {
            source = FileDataListSingleton.GetInstance();
        }
        public void CreateOrUpdate(PrintingProductBindingModel model)
        {
            PrintingProduct element = source.PrintingProducts.FirstOrDefault(rec => rec.PrintingProductName == model.PrintingProductName && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть корабль с таким названием");
            }
            if (model.Id.HasValue)
            {
                element = source.PrintingProducts.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Элемент не найден");
                }
            }
            else
            {
                int maxId = source.PrintingProducts.Count > 0 ? source.Components.Max(rec => rec.Id) : 0;
                element = new PrintingProduct { Id = maxId + 1 };
                source.PrintingProducts.Add(element);
            }
            element.PrintingProductName = model.PrintingProductName;
            element.Price = model.Price;
            // удалили те, которых нет в модели
            source.PrintingProductComponents.RemoveAll(rec => rec.PrintingProductId == model.Id && !model.PrintingComponents.ContainsKey(rec.ComponentId));
            // обновили количество у существующих записей
            var updateComponents = source.PrintingProductComponents.Where(rec => rec.PrintingProductId == model.Id && model.PrintingComponents.ContainsKey(rec.ComponentId));
            foreach (var updateComponent in updateComponents)
            {
                updateComponent.Count = model.PrintingComponents[updateComponent.ComponentId].Item2;
                model.PrintingComponents.Remove(updateComponent.ComponentId);
            }
            // добавили новые
            int maxPCId = source.PrintingProductComponents.Count > 0 ? source.PrintingProductComponents.Max(rec => rec.Id) : 0;
            foreach (var pc in model.PrintingComponents)
            {
                source.PrintingProductComponents.Add(new PrintingComponent
                {
                    Id = ++maxPCId,
                    PrintingProductId = element.Id,
                    ComponentId = pc.Key,
                    Count = pc.Value.Item2
                });
            }
        }
        public void Delete(PrintingProductBindingModel model)
        {
            // удаяем записи по компонентам при удалении изделия
            source.PrintingProductComponents.RemoveAll(rec => rec.PrintingProductId == model.Id);
            PrintingProduct element = source.PrintingProducts.FirstOrDefault(rec => rec.Id == model.Id);
            if (element != null)
            {
                source.PrintingProducts.Remove(element);
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        public List<PrintingProductViewModel> Read(PrintingProductBindingModel model)
        {
            return source.PrintingProducts
            .Where(rec => model == null || rec.Id == model.Id)
            .Select(rec => new PrintingProductViewModel
            {
                Id = rec.Id,
                PrintingProductName = rec.PrintingProductName,
                Price = rec.Price,
                PrintingComponents = source.PrintingProductComponents
            .Where(recPC => recPC.PrintingProductId == rec.Id)
            .ToDictionary(recPC => recPC.ComponentId, recPC =>
            (source.Components.FirstOrDefault(recC => recC.Id == recPC.ComponentId)?.ComponentName, recPC.Count))
            })
            .ToList();
        }
    }
}
