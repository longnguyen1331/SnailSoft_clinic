using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.ProductTypes
{
    public class ProductTypeDto: BaseDto
    {
        public int? ParentId { get; set; }
        public string ParentName { get; set; }
        public List<ProductTypeDto> Subs { get; set; }
    }
}
