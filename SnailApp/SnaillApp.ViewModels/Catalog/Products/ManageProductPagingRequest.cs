﻿using SnailApp.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SnailApp.ViewModels.Catalog.Products
{
    public class ManageProductPagingRequest : PagingRequestBase
    {
        public int? ProductTypeId { get; set; }
        public int StoreId { set; get; }
    }
}