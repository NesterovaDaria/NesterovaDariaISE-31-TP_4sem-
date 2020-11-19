﻿using PrintingHouseBusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintingHouseBusinessLogic.HelperModels
{
    class ExcelInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<IGrouping<DateTime, OrderViewModel>> Orders { get; set; }
    }
}
