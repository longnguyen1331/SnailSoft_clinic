﻿using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Enums;

namespace SnailApp.ViewModels.Catalog.Stores
{
    public class StoreDto : BaseDto
    {
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public string Website { get; set; }
        public string Taxcode { get; set; }
        public string Logo { get; set; }
        public int? StoreStatusId { get; set; }
        public string StoreStatusName { set; get; }
    }
    
}