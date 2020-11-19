using System;
using System.Collections.Generic;
using PrintingHouseBusinessLogic.Attributes;
using System.ComponentModel;
using System.Text;

namespace PrintingHouseBusinessLogic.ViewModels
{
    /// <summary>     
    /// Ингредиент, требуемый для изготовления изделия 
    /// </summary> 
    public class ComponentViewModel : BaseViewModel
    {
        [Column(title: "Компонент", gridViewAutoSize: GridViewAutoSize.Fill)]
        public string ComponentName { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "ComponentName"
        };
    }
}
