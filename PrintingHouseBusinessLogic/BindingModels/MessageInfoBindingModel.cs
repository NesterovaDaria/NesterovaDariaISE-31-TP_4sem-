﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace PrintingHouseBusinessLogic.BindingModels
{
    /// <summary>
    /// Сообщения, приходящие на почту
    /// </summary>
    [DataContract]
    public class MessageInfoBindingModel
    {
        [DataMember]
        public int? ClientId { get; set; }
        [DataMember]
        public string MassageId { get; set; }
        [DataMember]
        public string FromMailAddress { get; set; }
        [DataMember]
        public string Subject { get; set; }
        [DataMember]
        public string Body { get; set; }
        [DataMember]
        public DateTime DateDelivery { get; set; }
    }
}
