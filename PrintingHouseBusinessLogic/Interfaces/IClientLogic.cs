using PrintingHouseBusinessLogic.BindingModels;
using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrintingHouseBusinessLogic.Interfaces
{
    public interface IClientLogic
    {
        List<ClientViewModel> Read(ClientBindingModel model);
        void CreateOrUpdate(ClientBindingModel model);
        void Delete(ClientBindingModel model);
    }
}
