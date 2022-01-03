﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnailApp.ViewModels.Common;
using SnailApp.ViewModels.Catalog.DocTemplateTypes;
using SnailApp.ViewModels.Catalog.PaperSizes;

namespace SnailApp.ViewModels.System.DocTemplates
{
    public class DocTemplateDto: BaseDto
    {
        public string StoreName { set; get; }
        public string StoreAddress { set; get; }
        public string StorePhone { set; get; }
        public string Content { set; get; }
        public DocTemplateTypeDto DocTemplateType { set; get; }
        public PaperSizeDto PaperSize { set; get; }
    }
}