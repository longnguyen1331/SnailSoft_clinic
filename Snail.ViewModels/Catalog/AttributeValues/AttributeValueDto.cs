using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Catalog.AttributeValues
{
    public class AttributeValueDto : BaseDto
    {
        public int? AttributeId { set; get; }
        public string AttributeName { set; get; }
    }
}