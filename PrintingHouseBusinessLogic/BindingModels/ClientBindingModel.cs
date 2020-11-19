﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace PrintingHouseBusinessLogic.BindingModels
{
    //клиент
    public class ClientBindingModel
    {
        [DataMember]
        public int? Id { get; set; }

        [DataMember]
        public string FIO { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}
