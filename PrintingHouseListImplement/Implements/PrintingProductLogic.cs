using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseListImplement.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            PrintingProduct tempPrintingProduct = model.Id.HasValue ? null : new PrintingProduct { Id = 1 };
            foreach (var printingProduct in source.PrintingProducts)
            {
                if (printingProduct.PrintingProductName == model.PrintingProductName && printingProduct.Id != model.Id)
                {
                    throw new Exception("Уже есть печатное изделие с таким названием");
                }
                if (!model.Id.HasValue && printingProduct.Id >= tempPrintingProduct.Id)
                {
                    tempPrintingProduct.Id = printingProduct.Id + 1;
                }
                else if (model.Id.HasValue && printingProduct.Id == model.Id)
                {
                    tempPrintingProduct = printingProduct;
                }
            }
            if (model.Id.HasValue)
            {
                if (tempPrintingProduct == null)
                {
                    throw new Exception("Элемент не найден");
                }
                CreateModel(model, tempPrintingProduct);
            }
            else
            {
                source.PrintingProducts.Add(CreateModel(model, tempPrintingProduct));
            }
        }
        public void Delete(PrintingProductBindingModel model)
        {
            for (int i = 0; i < source.PrintingComponents.Count; ++i)
            {
                if (source.PrintingComponents[i].PrintingProductId == model.Id)
                {
                    source.PrintingComponents.RemoveAt(i--);
                }
            }
            for (int i = 0; i < source.PrintingProducts.Count; ++i)
            {
                if (source.PrintingProducts[i].Id == model.Id)
                {
                    source.PrintingProducts.RemoveAt(i);
                    return;
                }
            }
            throw new Exception("Элемент не найден");
        }
        private PrintingProduct CreateModel(PrintingProductBindingModel model, PrintingProduct printingProduct)
        {
            printingProduct.PrintingProductName = model.PrintingProductName;
            printingProduct.Price = model.Price;
            int maxPCId = 0;
            for (int i = 0; i < source.PrintingComponents.Count; ++i)
            {
                if (source.PrintingComponents[i].Id > maxPCId)
                {
                    maxPCId = source.PrintingComponents[i].Id;
                }
                if (source.PrintingComponents[i].PrintingProductId == printingProduct.Id)
                {
                    if
                    (model.PrintingComponents.ContainsKey(source.PrintingComponents[i].ComponentId))
                    {
                        source.PrintingComponents[i].Count =
                        model.PrintingComponents[source.PrintingComponents[i].ComponentId].Item2;
                        model.PrintingComponents.Remove(source.PrintingComponents[i].PrintingProductId);
                    }
                    else
                    {
                        source.PrintingComponents.RemoveAt(i--);
                    }
                }
            }
            foreach (var ia in model.PrintingComponents)
            {
                source.PrintingComponents.Add(new PrintingComponent
                {
                    Id = ++maxPCId,
                    PrintingProductId = printingProduct.Id,
                    ComponentId = ia.Key,
                    Count = ia.Value.Item2
                });
            }
            return printingProduct;
        }
        public List<PrintingProductViewModel> Read(PrintingProductBindingModel model)
        {
            List<PrintingProductViewModel> result = new List<PrintingProductViewModel>();
            foreach (var component in source.PrintingProducts)
            {
                if (model != null)
                {
                    if (component.Id == model.Id)
                    {
                        result.Add(CreateViewModel(component));
                        break;
                    }
                    continue;
                }
                result.Add(CreateViewModel(component));
            }
            return result;
        }
        private PrintingProductViewModel CreateViewModel(PrintingProduct printingProduct)
        {
            Dictionary<int, (string, int)> printingComponents = new Dictionary<int, (string, int)>();
            foreach (var ia in source.PrintingComponents)
            {
                if (ia.PrintingProductId == printingProduct.Id)
                {
                    string componentName = string.Empty;
                    foreach (var component in source.Components)
                    {
                        if (ia.ComponentId == component.Id)
                        {
                            componentName = component.ComponentName;
                            break;
                        }
                    }
                    printingComponents.Add(ia.ComponentId, (componentName, ia.Count));
                }
            }
            return new PrintingProductViewModel
            {
                Id = printingProduct.Id,
                PrintingProductName = printingProduct.PrintingProductName,
                Price = printingProduct.Price,
                PrintingComponents = printingComponents
            };
        }
    }
}

