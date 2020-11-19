using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.BusinessLogics;
using PrintingHouseBusinessLogic.Interfaces;
using PrintingHouseBusinessLogic.ViewModels;
using PrintingHouseRestApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PrintingHouseRestApi.Controllers
{
    [Route("api/main/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IOrderLogic _order;
        private readonly IPrintingProductLogic _product;
        private readonly MainLogic _main;
        public MainController(IOrderLogic order, IPrintingProductLogic product,MainLogic main)
        {
            _order = order;
            _product = product;
            _main = main;
        }
        [HttpGet]
        public List<PrintingProductViewModel> List() => _product.Read(null).ToList();

        [HttpGet]
        public List<PrintingProductModel> GetPrintingProductList() => _product.Read(null)?.Select(rec => Convert(rec)).ToList();
        [HttpGet]
        public PrintingProductModel GetPrintingProduct(int productId) => Convert(_product.Read(new PrintingProductBindingModel { Id = productId })?[0]);
        [HttpGet]
        public List<OrderViewModel> GetOrders(int clientId) => _order.Read(new OrderBindingModel { ClientId = clientId });
        [HttpPost]
        //public void CreateOrder(OrderBindingModel model) => _order.CreateOrUpdate(model);
        public void CreateOrder(CreateOrderBindingModel model) => _main.CreateOrder(model);
        private PrintingProductModel Convert(PrintingProductViewModel model)
        {
            if (model == null) return null;
            return new PrintingProductModel
            {
                Id = model.Id,
                PrintingProductName = model.PrintingProductName,
                Price = model.Price
            };
        }
    }
}