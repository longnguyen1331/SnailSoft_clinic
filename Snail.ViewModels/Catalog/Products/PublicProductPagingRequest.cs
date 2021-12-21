using Snail.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Catalog.Products
{
    public class PublicProductPagingRequest : PagingRequestBase
    {
        public int? ProductTypeId { get; set; }
    }
}