using System;
using System.Collections.Generic;
using System.Text;
using Snail.ViewModels.Common;

namespace Snail.ViewModels.Utilities.Slides
{
    public class SlideDto: BaseDto
    {
        public string Link { set; get; }
        public string Image { get; set; }
    }
}