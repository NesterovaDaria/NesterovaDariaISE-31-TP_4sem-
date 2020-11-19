using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.HelperModels;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintingHouseBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        private readonly IComponentLogic componentLogic;
        private readonly IPrintingProductLogic productLogic;
        private readonly IOrderLogic orderLogic;
        public ReportLogic(IPrintingProductLogic productLogic, IComponentLogic componentLogic, IOrderLogic orderLogic)
        {
            this.productLogic = productLogic;
            this.componentLogic = componentLogic;
            this.orderLogic = orderLogic;
        }
        /// <summary>
        /// Получение списка компонент с указанием, в каких изделиях используются
        /// </summary>
        /// <returns></returns>
        public List<ReportPrintingComponentViewModel> GetProductComponent()
        {
            var components = componentLogic.Read(null);
            var products = productLogic.Read(null);
            var list = new List<ReportPrintingComponentViewModel>();
            foreach (var product in products)
            {
                foreach (var component in components)
                {
                    if (product.PrintingComponents.ContainsKey(component.Id))
                    {
                        list.Add(new ReportPrintingComponentViewModel
                        {
                            PrintingProductName = product.PrintingProductName,
                            ComponentName = component.ComponentName,
                            Count = product.PrintingComponents[component.Id].Item2
                        });
                    }
                }
            }           
            return list;
        }
        /// <summary>
        /// Получение списка заказов за определенный период
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public List<ReportOrdersViewModel> GetOrders(ReportBindingModel model)
        {
            return orderLogic.Read(new OrderBindingModel
            {
                DateFrom = model.DateFrom,
                DateTo = model.DateTo
            })
            .Select(x => new ReportOrdersViewModel
            {
                DateCreate = x.DateCreate,
                PrintingProductName = x.PrintingProductName,
                Count = x.Count,
                Sum = x.Sum,
                Status = x.Status
            })
            .ToList();

        }
        /// <summary>
        /// Сохранение компонент в файл-Word
        /// </summary>
        /// <param name="model"></param>
        public void SaveProductsToWordFile(ReportBindingModel model)
        {
            SaveToWord.CreateDoc(new WordInfo
            {
                FileName = model.FileName,
                Title = "Список изделий",
                PrintingProducts = productLogic.Read(null)
            });
        }
        /// <summary>
        /// Сохранение компонент с указаеним продуктов в файл-Excel
        /// </summary>
        /// <param name="model"></param>
        public void SaveOrdersToExcelFile(ReportBindingModel model)
        {
            SaveToExcel.CreateDoc(new ExcelInfo
            {
                FileName = model.FileName,
                Title = "Список заказов",
                Orders = GetOrders(model)
            });
        }
        /// <summary>
        /// Сохранение заказов в файл-Pdf
        /// </summary>
        /// <param name="model"></param>
        public void SaveProductComponentsToPdfFile(ReportBindingModel model)
        {
            SaveToPdf.CreateDoc(new PdfInfo
            {
                FileName = model.FileName,
                Title = "Список изделий с компонентами",
                PrintingComponents = GetProductComponent()
            });
        }
    }
}
