﻿using System;
namespace WebApp.Models
{
    public class ExportOrder : Order
    {
        public StoreBranch Destination { get; set; }
        public DateTime ExportDate { get; set; }
    }
}

