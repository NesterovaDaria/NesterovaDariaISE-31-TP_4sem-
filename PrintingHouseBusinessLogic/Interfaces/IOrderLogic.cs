using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseBusinessLogic.Interfaces
{
    public interface IOrderLogic
    {
        List<OrderViewModel> Read(OrderBindingModel model);
        void CreateOrUpdate(OrderBindingModel model);
        void Delete(OrderBindingModel model);
    }
}
