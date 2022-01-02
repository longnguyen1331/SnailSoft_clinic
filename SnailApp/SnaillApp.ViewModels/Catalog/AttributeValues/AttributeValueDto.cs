using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Catalog.AttributeValues
{
    public class AttributeValueDto : BaseDto
    {
        public int? AttributeId { set; get; }
        public string AttributeName { set; get; }
    }
}