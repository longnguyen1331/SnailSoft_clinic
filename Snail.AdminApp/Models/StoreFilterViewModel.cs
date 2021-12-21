using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Snail.ViewModels.System.Users;
using Snail.ViewModels.Catalog.Stores;

namespace Snail.AdminApp.Models
{
    public class StoreFilterViewModel : BaseViewModel
    {
        public string StoreNameSelected { set; get; }
        public string OptionStores { set; get; }
    }
}
