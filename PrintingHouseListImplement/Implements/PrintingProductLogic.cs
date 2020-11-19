using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseListImplement.Models;
using System;
using System.Collections.Generic;

namespace PrintingHouseListImplement.Implements
{
    public class PrintingProductLogic : IPrintingProductLogic
    {
        private readonly DataListSingleton source;

        public PrintingProductLogic()
        {
            source = DataListSingleton.GetInstance();
        }

        public void CreateOrUpdate(PrintingProductBindingModel model)
        {
            PrintingProduct tempProduct = model.Id.HasValue ? null : new PrintingProduct { Id = 1 };
            foreach (var product in source.PrintingProducts)
            {
                if (product.PrintingProductName == model.PrintingProductName && product.Id != model.Id)
                    throw new Exception("Уже есть корабль с таким названием");
                if (!model.Id.HasValue && product.Id >= tempProduct.Id)
                    tempProduct.Id = product.Id + 1;
                else if (model.Id.HasValue && product.Id == model.Id)
                    tempProduct = product;
            }
            if (model.Id.HasValue)
            {
                if (tempProduct == null)
                    throw new Exception("Элемент не найден");
                CreateModel(model, tempProduct);
            }
            else
                source.PrintingProducts.Add(CreateModel(model, tempProduct));
        }

        public void Delete(PrintingProductBindingModel model)
        {
            // удаляем записи по ингредиентам при удалении изделия
            for (int i = 0; i < source.PrintingComponents.Count; ++i)
                if (source.PrintingComponents[i].ProductId == model.Id)
                    source.PrintingComponents.RemoveAt(i--);
            for (int i = 0; i < source.PrintingProducts.Count; ++i)
                if (source.PrintingProducts[i].Id == model.Id)
                {
                    source.PrintingProducts.RemoveAt(i);
                    return;
                }
            throw new Exception("Элемент не найден");
        }

        public List<PrintingProductViewModel> Read(PrintingProductBindingModel model)
        {
            List<PrintingProductViewModel> result = new List<PrintingProductViewModel>();
            foreach (var ingredient in source.PrintingProducts)
            {
                if (model != null)
                {
                    if (ingredient.Id == model.Id)
                    {
                        result.Add(CreateViewModel(ingredient));
                        break;
                    }
                    continue;
                }
                result.Add(CreateViewModel(ingredient));
            }
            return result;
        }

        private PrintingProduct CreateModel(PrintingProductBindingModel model, PrintingProduct product)
        {
            product.PrintingProductName = model.PrintingProductName;
            product.Price = model.Price;
            //обновляем существуюущие ингредиенты и ищем максимальный идентификатор
            int maxPCId = 0;
            for (int i = 0; i < source.PrintingComponents.Count; ++i)
            {
                if (source.PrintingComponents[i].Id > maxPCId)
                    maxPCId = source.PrintingComponents[i].Id;
                if (source.PrintingComponents[i].ProductId == product.Id)
                {
                    // если в модели пришла запись ингредиента с таким id
                    if (model.PrintingComponents.ContainsKey(source.PrintingComponents[i].IngredientId))
                    {
                        // обновляем количество
                        source.PrintingComponents[i].Count =
                            model.PrintingComponents[source.PrintingComponents[i].IngredientId].Item2;
                        // из модели убираем эту запись, чтобы остались только не просмотренные
                        model.PrintingComponents.Remove(source.PrintingComponents[i].IngredientId);
                    }
                    else
                        source.PrintingComponents.RemoveAt(i--);
                }
            }
            // новые записи
            foreach (var pi in model.PrintingComponents)
            {
                source.PrintingComponents.Add(new PrintingComponents
                {
                    Id = ++maxPCId,
                    ProductId = product.Id,
                    IngredientId = pi.Key,
                    Count = pi.Value.Item2
                });
            }
            return product;
        }

        private PrintingProductViewModel CreateViewModel(PrintingProduct product)
        {
            // требуется дополнительно получить список компонентов для изделия с названиями и их количество
            Dictionary<int, (string, int)> productIngredients = new Dictionary<int, (string, int)>();
            foreach (var pi in source.PrintingComponents)
                if (pi.ProductId == product.Id)
                {
                    string componentName = string.Empty;
                    foreach (var component in source.Components)
                        if (pi.IngredientId == component.Id)
                        {
                            componentName = component.ComponentName;
                            break;
                        }
                    productIngredients.Add(pi.IngredientId, (componentName, pi.Count));
                }
            return new PrintingProductViewModel
            {
                Id = product.Id,
                PrintingProductName = product.PrintingProductName,
                Price = product.Price,
                PrintingComponents = productIngredients
            };
        }
    }
}
