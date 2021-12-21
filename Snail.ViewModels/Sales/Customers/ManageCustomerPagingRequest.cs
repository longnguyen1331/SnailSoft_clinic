﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Sales.Customers
{
    public class ManageCustomerPagingRequest : PagingRequestBase
    {
        public bool IsSupplier { set; get; }
        public bool IsCustomer { set; get; }
        public int StoreId { set; get; }
    }
}
