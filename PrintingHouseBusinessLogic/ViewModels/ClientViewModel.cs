using System;
using System.Collections.Generic;
using System.Text;
using PrintingHouseBusinessLogic.Attributes;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace PrintingHouseBusinessLogic.ViewModels
{
    [DataContract]
    public class ClientViewModel : BaseViewModel
    {
        [Column(title: "ФИО клиента", gridViewAutoSize: GridViewAutoSize.Fill)]
        [DataMember]
        public string FIO { get; set; }
        [Column(title: "Логин(Почта)", width: 150)]
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
        public override List<string> Properties() => new List<string>
        {
            "Id",
            "FIO",
            "Login"
        };
    }
}
