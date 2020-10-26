using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseBusinessLogic.Interfaces
{
    public interface IPrintingProductLogic
    {
        List<PrintingProductViewModel> Read(PrintingProductBindingModel model);
        void CreateOrUpdate(PrintingProductBindingModel model);
        void Delete(PrintingProductBindingModel model);
    }
}

