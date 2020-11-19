﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrintingHouseDatabaseImplement.Models
{
    public class Client
    {
        public int Id { get; set; }
        [Required]
        public string FIO { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [ForeignKey("ClientId")]
        public virtual List <Order> Orders { set; get; }
    }
}
