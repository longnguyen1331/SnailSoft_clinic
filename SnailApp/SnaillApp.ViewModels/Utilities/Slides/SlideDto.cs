using System;
using System.Collections.Generic;
using System.Text;
using SnailApp.ViewModels.Common;

namespace SnailApp.ViewModels.Utilities.Slides
{
    public class SlideDto: BaseDto
    {
        public string Link { set; get; }
        public string Image { get; set; }
    }
}