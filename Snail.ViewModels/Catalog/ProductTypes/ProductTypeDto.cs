using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.ProductTypes
{
    public class ProductTypeDto: BaseDto
    {
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        public List<ProductTypeDto> Subs { get; set; }
    }
}
