using Snail.ViewModels.Catalog.ProductTypes;
using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.ProductSKUs
{
    public class ProductSKU_AttributeValueDto
    {
        public int Id { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ProductSKUId { set; get; }
        public string ProductSKUName { set; get; }
        public string ProductSKUCode { set; get; }
        public string AttributeValueIds { set; get; }
        public int AttributeValueId { set; get; }
        public int AttributeId { set; get; }
        public string AttributeIds { set; get; }
        public string AttributeName { set; get; }
        public string AttributeNames { set; get; }
        public string AttributeValueName { set; get; }
        public double Price { set; get; }
        public double BuyingPrice { set; get; }
        public int QtyInStock { set; get; }
    }
}