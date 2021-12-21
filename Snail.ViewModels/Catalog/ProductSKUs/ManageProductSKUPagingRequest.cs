﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.ProductSKUs
{
    public class ManageProductSKUPagingRequest: PagingRequestBase
    {
        public int? ProductId { set; get; }
        public int StoreId { set; get; }
    }
}
