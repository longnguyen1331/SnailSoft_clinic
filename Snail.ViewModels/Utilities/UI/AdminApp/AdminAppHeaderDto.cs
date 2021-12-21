﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Snail.ViewModels.System.Languages;

namespace Snail.ViewModels.Utilities.UI.AdminApp
{
    public class AdminAppHeaderDto
    {
        public string  Email { set; get; }
        public string FullName { set; get; }
        public string UserImage { set; get; }
        public List<LanguageDto> Languages { set; get; }
    }
}
