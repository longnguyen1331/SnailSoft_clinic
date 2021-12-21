using Snail.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snail.ViewModels.Catalog.Products
{
    public class ProductTypeAssignRequest
    {
        public int Id { get; set; }
        public List<SelectItem> ProductTypes { get; set; } = new List<SelectItem>();
    }
}