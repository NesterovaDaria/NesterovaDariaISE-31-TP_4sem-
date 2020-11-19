using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PrintingHouseBusinessLogic.ViewModels
{
    /// <summary>     
    /// Ингредиент, требуемый для изготовления изделия 
    /// </summary> 
    public class ComponentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Компонент")]
        public string ComponentName { get; set; }
    }
}
