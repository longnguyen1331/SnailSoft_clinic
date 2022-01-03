﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SnailApp.ViewModels.System.Users;
using SnailApp.ViewModels.Catalog.Stores;

namespace SnailApp.AdminApp.Models
{
    public class StoreFilterViewModel : BaseViewModel
    {
        public string StoreNameSelected { set; get; }
        public string OptionStores { set; get; }
    }
}