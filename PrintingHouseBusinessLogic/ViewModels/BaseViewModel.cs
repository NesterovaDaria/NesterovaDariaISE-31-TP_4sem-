using System;
using System.Collections.Generic;
using System.Text;
using PrintingHouseBusinessLogic.Attributes;
using System.Runtime.Serialization;

namespace PrintingHouseBusinessLogic.ViewModels
{
    /// Базовый класс для View-моделей
    [DataContract]
    public abstract class BaseViewModel
    {
        [Column(visible: false)]
        [DataMember]
        public int Id { get; set; }
        public abstract List<string> Properties();
    }
}
